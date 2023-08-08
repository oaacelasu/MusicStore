using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlbumController : Controller
    {
        private MusicStoreUnitOfWork data { get; set; }
        public AlbumController(MusicStoreContext ctx) => data = new MusicStoreUnitOfWork(ctx);

        public ViewResult Index() {
            var search = new SearchData(TempData);
            search.Clear();

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Search(SearchViewModel vm)
        {
            if (ModelState.IsValid) {
                var search = new SearchData(TempData) {
                    SearchTerm = vm.SearchTerm,
                    Type = vm.Type
                };
                return RedirectToAction("Search");
            }  
            else {
                return RedirectToAction("Index");
            }   
        }

        [HttpGet]
        public ViewResult Search() 
        {
            var search = new SearchData(TempData);

            if (search.HasSearchTerm) {
                var vm = new SearchViewModel {
                    SearchTerm = search.SearchTerm
                };

                var options = new QueryOptions<Album> {
                    Includes = "Genre, AlbumArtists.Artist"
                };
                if (search.IsAlbum) { 
                    options.Where = b => b.Title.Contains(vm.SearchTerm);
                    vm.Header = $"Search results for album title '{vm.SearchTerm}'";
                }
                if (search.IsArtist) {
                    int index = vm.SearchTerm.LastIndexOf(' ');
                    if (index == -1) {
                        options.Where = b => b.AlbumArtists.Any(
                            ba => ba.Artist.FullName.Contains(vm.SearchTerm));
                    }
                    else {
                        string first = vm.SearchTerm.Substring(0, index);
                        string last = vm.SearchTerm.Substring(index + 1); 
                        options.Where = b => b.AlbumArtists.Any(
                            ba => ba.Artist.FullName.Contains(first));
                    }
                    vm.Header = $"Search results for artist '{vm.SearchTerm}'";
                }
                if (search.IsGenre) {                  
                    options.Where = b => b.GenreId.Contains(vm.SearchTerm);
                    vm.Header = $"Search results for genre ID '{vm.SearchTerm}'";
                }
                vm.Albums = data.Albums.List(options);
                return View("SearchResults", vm);
            }
            else {
                return View("Index");
            }     
        }

        [HttpGet]
        public ViewResult Add(int id) => GetAlbum(id, "Add");

        [HttpPost]
        public IActionResult Add(AlbumViewModel vm)
        {
            if (ModelState.IsValid) {
                data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);
                data.Albums.Insert(vm.Album);
                data.Save();

                TempData["message"] = $"{vm.Album.Title} added to Albums.";
                return RedirectToAction("Index");  
            }
            else {
                Load(vm, "Add");
                return View("Album", vm);
            }
        }

        [HttpGet]
        public ViewResult Edit(int id) => GetAlbum(id, "Edit");
        
        [HttpPost]
        public IActionResult Edit(AlbumViewModel vm)
        {
            if (ModelState.IsValid) {
                data.DeleteCurrentAlbumArtists(vm.Album);
                data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);

                data.Albums.Update(vm.Album);
                data.Save(); 
                
                TempData["message"] = $"{vm.Album.Title} updated.";
                return RedirectToAction("Search");  
            }
            else {
                Load(vm, "Edit");
                return View("Album", vm);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id) => GetAlbum(id, "Delete");

        [HttpPost]
        public IActionResult Delete(AlbumViewModel vm)
        {
            data.Albums.Delete(vm.Album); 
            data.Save();
            TempData["message"] = $"{vm.Album.Title} removed from Albums.";
            return RedirectToAction("Search");  
        }

        private ViewResult GetAlbum(int id, string operation)
        {
            var album = new AlbumViewModel();
            Load(album, operation, id);
            return View("Album", album);
        }
        private void Load(AlbumViewModel vm, string op, int? id = null)
        {
            if (Operation.IsAdd(op)) { 
                vm.Album = new Album();
            }
            else {
                vm.Album = data.Albums.Get(new QueryOptions<Album>
                {
                    Includes = "AlbumArtists.Artist, Genre",
                    Where = b => b.AlbumId == (id ?? vm.Album.AlbumId)
                });
            }

            vm.SelectedArtists = vm.Album.AlbumArtists?.Select(
                ba => ba.Artist.ArtistId).ToArray();
            vm.Artists = data.Artists.List(new QueryOptions<Artist> {
                OrderBy = a => a.FullName });
            vm.Genres = data.Genres.List(new QueryOptions<Genre> {
                    OrderBy = g => g.Name });
        }

    }
}