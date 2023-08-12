using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using Newtonsoft.Json.Linq;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlbumController : Controller
    {
        private MusicStoreUnitOfWork data { get; set; }
        public AlbumController(MusicStoreContext ctx) => data = new MusicStoreUnitOfWork(ctx);

        public ViewResult Index()
        {
            var search = new SearchData(TempData);
            search.Clear();

            return View();
        }

        public async Task<ViewResult> SyncApi()
        {
            var search = new SearchData(TempData);
            search.Clear();
            await LoadNewAlbumsAsync();
            return View("Index");
        }

        [HttpPost]
        public RedirectToActionResult Search(SearchViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var search = new SearchData(TempData)
                {
                    SearchTerm = vm.SearchTerm,
                    Type = vm.Type
                };
                return RedirectToAction("Search");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ViewResult Search()
        {
            var search = new SearchData(TempData);

            if (search.HasSearchTerm)
            {
                var vm = new SearchViewModel
                {
                    SearchTerm = search.SearchTerm
                };

                var options = new QueryOptions<Album>
                {
                    Includes = "Genre, AlbumArtists.Artist"
                };
                if (search.IsAlbum)
                {
                    options.Where = b => b.Title.Contains(vm.SearchTerm);
                    vm.Header = $"Search results for album title '{vm.SearchTerm}'";
                }

                if (search.IsArtist)
                {
                    int index = vm.SearchTerm.LastIndexOf(' ');
                    if (index == -1)
                    {
                        options.Where = b => b.AlbumArtists.Any(
                            ba => ba.Artist.FullName.Contains(vm.SearchTerm));
                    }
                    else
                    {
                        string first = vm.SearchTerm.Substring(0, index);
                        string last = vm.SearchTerm.Substring(index + 1);
                        options.Where = b => b.AlbumArtists.Any(
                            ba => ba.Artist.FullName.Contains(first));
                    }

                    vm.Header = $"Search results for artist '{vm.SearchTerm}'";
                }

                if (search.IsGenre)
                {
                    options.Where = b => b.GenreId.Contains(vm.SearchTerm);
                    vm.Header = $"Search results for genre ID '{vm.SearchTerm}'";
                }

                vm.Albums = data.Albums.List(options);
                return View("SearchResults", vm);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public ViewResult Add(int id) => GetAlbum(id, "Add");

        [HttpPost]
        public IActionResult Add(AlbumViewModel vm)
        {
            if (ModelState.IsValid)
            {
                data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);
                data.Albums.Insert(vm.Album);
                data.Save();

                TempData["message"] = $"{vm.Album.Title} added to Albums.";
                return RedirectToAction("Index");
            }
            else
            {
                Load(vm, "Add");
                return View("Album", vm);
            }
        }

        [HttpGet]
        public ViewResult Edit(int id) => GetAlbum(id, "Edit");

        [HttpPost]
        public IActionResult Edit(AlbumViewModel vm)
        {
            if (ModelState.IsValid)
            {
                data.DeleteCurrentAlbumArtists(vm.Album);
                data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);

                data.Albums.Update(vm.Album);
                data.Save();

                TempData["message"] = $"{vm.Album.Title} updated.";
                return RedirectToAction("Search");
            }
            else
            {
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
            if (Operation.IsAdd(op))
            {
                vm.Album = new Album();
            }
            else
            {
                vm.Album = data.Albums.Get(new QueryOptions<Album>
                {
                    Includes = "AlbumArtists.Artist, Genre",
                    Where = b => b.AlbumId == (id ?? vm.Album.AlbumId)
                });
            }

            vm.SelectedArtists = vm.Album.AlbumArtists?.Select(
                ba => ba.Artist.ArtistId).ToArray();
            vm.Artists = data.Artists.List(new QueryOptions<Artist>
            {
                OrderBy = a => a.FullName
            });
            vm.Genres = data.Genres.List(new QueryOptions<Genre>
            {
                OrderBy = g => g.Name
            });
        }

        private void LoadNewAlbums()
        {
            var newList = new List<Album>(); // data to be loaded

            foreach (var album in newList)
            {
                var vm = new AlbumViewModel();
                vm.Album = album;
                data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);
                data.Albums.Insert(vm.Album);
                data.Save();
            }
        }


        private async Task LoadNewAlbumsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string jsonUrl = "https://itunes.apple.com/us/rss/topalbums/limit=100/json";
                HttpResponseMessage response = await client.GetAsync(jsonUrl);

                if (response.IsSuccessStatusCode)
                {
                    int counter = 0;
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject root = JObject.Parse(jsonResponse);

                    var albumEntries = root["feed"]["entry"];
                    if (albumEntries != null)
                    {
                        foreach (var albumEntry in albumEntries)
                        {
                            // check if album already exists
                            data.Albums.List(new QueryOptions<Album>
                            {
                                Where = b => b.Title == albumEntry["im:name"]["label"].ToString()
                            });

                            if (data.Albums.Count > 0)
                            {
                                continue;
                            }

                            // check if genre already exists if not add it
                            string genreName = albumEntry["category"]["attributes"]["term"].ToString();

                            string genreId = genreName.ToLower().Replace(" ", "");

                            data.Genres.List(new QueryOptions<Genre>
                            {
                                Where = g => g.GenreId == genreId
                            });

                            if (data.Genres.Count == 0)
                            {
                                var genre = new Genre
                                {
                                    Name = genreName,
                                    GenreId = genreId
                                };
                                data.Genres.Insert(genre);
                                data.Save();
                            }

                            // check if artist already exists if not add it
                            string artistName = albumEntry["im:artist"]["label"].ToString();

                            data.Artists.List(new QueryOptions<Artist>
                            {
                                Where = a => a.FullName == artistName
                            });

                            if (data.Artists.Count == 0)
                            {
                                var artist = new Artist
                                {
                                    FullName = artistName
                                };
                                data.Artists.Insert(artist);
                                data.Save();
                            }

                            int? artistId = data.Artists.List(new QueryOptions<Artist>
                            {
                                Where = a => a.FullName == artistName
                            }).FirstOrDefault()?.ArtistId;

                            if (artistId == null)
                            {
                                continue;
                            }

                            var album = new Album
                            {
                                Title = albumEntry["im:name"]["label"].ToString(),
                                GenreId = genreId,
                                Price = double.Parse(albumEntry["im:price"]["attributes"]["amount"].ToString()),
                                ReleaseDate =
                                    DateTime.Parse(albumEntry["im:releaseDate"]["attributes"]["label"].ToString()),
                                Image = albumEntry["im:image"][2]["label"].ToString()
                            };

                            var vm = new AlbumViewModel();
                            vm.Album = album;
                            vm.SelectedArtists = new int[] { artistId.Value };
                            data.LoadNewAlbumArtists(vm.Album, vm.SelectedArtists);
                            data.Albums.Insert(vm.Album);
                            data.Save();
                            counter++;
                        }

                        if (counter > 0)
                        {
                            TempData["message"] = $"{counter} albums added to Albums.";
                        }
                        else
                        {
                            TempData["message"] = $"No new albums added to Albums.";
                        }
                    }
                }
                else
                {
                    TempData["message"] = $"Error loading albums";
                }
            }
        }
    }
}