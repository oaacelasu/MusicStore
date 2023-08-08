using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        private Repository<Genre> data { get; set; }
        public GenreController(MusicStoreContext ctx) => data = new Repository<Genre>(ctx);

        public ViewResult Index()
        {
            var search = new SearchData(TempData);
            search.Clear();

            var genres = data.List(new QueryOptions<Genre> {
                OrderBy = g => g.Name
            });
            return View(genres);
        }

        [HttpGet]
        public ViewResult Add() => View("Genre", new Genre());

        [HttpPost]
        public IActionResult Add(Genre genre)
        {
            var validate = new Validate(TempData);
            if (!validate.IsGenreChecked) {
                validate.CheckGenre(genre.GenreId, data);
                if (!validate.IsValid) {
                    ModelState.AddModelError(nameof(genre.GenreId), validate.ErrorMessage);
                }     
            }

            if (ModelState.IsValid) {
                data.Insert(genre);
                data.Save();
                validate.ClearGenre();
                TempData["message"] = $"{genre.Name} added to Genres.";
                return RedirectToAction("Index");  
            }
            else {
                return View("Genre", genre);
            }
        }

        [HttpGet]
        public ViewResult Edit(string id) => View("Genre", data.Get(id));

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid) {
                data.Update(genre);
                data.Save();
                TempData["message"] = $"{genre.Name} updated.";
                return RedirectToAction("Index");  
            }
            else {
                return View("Genre", genre);
            }
        }

        [HttpGet]
        public IActionResult Delete(string id) {
            var genre = data.Get(new QueryOptions<Genre> {
                Includes = "Albums",
                Where = g => g.GenreId == id
            });

            if (genre.Albums.Count > 0) {
                TempData["message"] = $"Can't delete genre {genre.Name} " 
                                    + "because it's associated with these albums.";
                return GoToAlbumSearchResults(id);
            }
            else {
                return View("Genre", genre);
            }
        }

        [HttpPost]
        public IActionResult Delete(Genre genre)
        {
            data.Delete(genre);
            data.Save();
            TempData["message"] = $"{genre.Name} removed from Genres.";
            return RedirectToAction("Index");  // PRG pattern
        }

        public RedirectToActionResult ViewAlbums(string id) {
            RedirectToActionResult result = GoToAlbumSearchResults(id);
            return result;
        }

        private RedirectToActionResult GoToAlbumSearchResults(string id)
        {
            var search = new SearchData(TempData) {
                SearchTerm = id,
                Type = "genre"
            };
            return RedirectToAction("Search", "Album");
        }

    }
}