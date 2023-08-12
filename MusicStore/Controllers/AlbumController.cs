using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        private IRepository<Album> data { get; set; }
        public AlbumController(IRepository<Album> rep) => data = rep;

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(AlbumsGridDTO values)
        {
            var builder = new AlbumsGridBuilder(HttpContext.Session, values, 
                defaultSortField: nameof(Album.Title));

            var options = new AlbumQueryOptions {
                Includes = "AlbumArtists.Artist, Genre",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new GridViewModel<Album> {
                Items = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count),
                TotalRecords = data.Count
            };

            return View(vm);
        }

        public ViewResult Details(int id)
        {
            var album = data.Get(new QueryOptions<Album> {
                Includes = "AlbumArtists.Artist, Genre",
                Where = b => b.AlbumId == id
            });
            return View(album);
        }

        [HttpPost]
        public RedirectToActionResult Filter([FromServices]IRepository<Artist> data, 
            string[] filter, bool clear = false)
        {
            var builder = new AlbumsGridBuilder(HttpContext.Session);

            if (clear) {
                builder.ClearFilterSegments();
            }
            else {
                var artist = data.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, artist);
            }

            builder.SaveRouteSegments();
            return RedirectToAction("List", builder.CurrentRoute);
        }
    }   
}