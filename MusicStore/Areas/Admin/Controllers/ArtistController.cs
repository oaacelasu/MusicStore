using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtistController : Controller
    {
        private Repository<Artist> data { get; set; }
        public ArtistController(MusicStoreContext ctx) => data = new Repository<Artist>(ctx);

        public ViewResult Index()
        {
            var artists = data.List(new QueryOptions<Artist> {
                OrderBy = a => a.FullName
            });
            return View(artists);
        }

        public RedirectToActionResult Select(int id, string operation)
        {
            switch (operation.ToLower())
            {
                case "view albums":
                    return RedirectToAction("ViewAlbums", new { id });
                case "edit":
                    return RedirectToAction("Edit", new { id });
                case "delete":
                    return RedirectToAction("Delete", new { id });
                default:
                    return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ViewResult Add() => View("Artist", new Artist());

        [HttpPost]
        public IActionResult Add(Artist artist, string operation)
        {
            var validate = new Validate(TempData);
            if (!validate.IsArtistChecked) {
                validate.CheckArtist(artist.FullName, operation, data);
                if (!validate.IsValid) {
                    ModelState.AddModelError(nameof(artist.FullName), validate.ErrorMessage);
                }    
            }
            
            if (ModelState.IsValid) {
                data.Insert(artist);
                data.Save();
                validate.ClearArtist();
                TempData["message"] = $"{artist.FullName} added to Artists.";
                return RedirectToAction("Index");  
            }
            else {
                return View("Artist", artist);
            }
        }

        [HttpGet]
        public ViewResult Edit(int id) => View("Artist", data.Get(id));

        [HttpPost]
        public IActionResult Edit(Artist artist)
        {
            if (ModelState.IsValid) {
                data.Update(artist);
                data.Save();
                TempData["message"] = $"{artist.FullName} updated.";
                return RedirectToAction("Index");  
            }
            else {
                return View("Artist", artist);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var artist = data.Get(new QueryOptions<Artist> {
                Includes = "AlbumArtists",
                Where = a => a.ArtistId == id
            });

            if (artist.AlbumArtists.Count > 0) {
                TempData["message"] = $"Can't delete artist {artist.FullName} because they are associated with these albums.";
                return GoToArtistSearch(artist);
            }
            else {
                return View("Artist", artist);
            }
        }

        [HttpPost]
        public RedirectToActionResult Delete(Artist artist)
        {
            data.Delete(artist);
            data.Save();
            TempData["message"] = $"{artist.FullName} removed from Artists.";
            return RedirectToAction("Index");  
        }

        public RedirectToActionResult ViewAlbums(int id)
        {
            var artist = data.Get(id);
            return GoToArtistSearch(artist);
        }

        private RedirectToActionResult GoToArtistSearch(Artist artist)
        {
            var search = new SearchData(TempData) {
                SearchTerm = artist.FullName,
                Type = "artist"
            };
            return RedirectToAction("Search", "Album");
        }
    }
}