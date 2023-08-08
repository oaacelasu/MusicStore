using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class ArtistController : Controller
    {
        private IRepository<Artist> data { get; set; }
        public ArtistController(IRepository<Artist> rep) => data = rep;

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List(GridDTO vals)
        {
            string defaultSort = nameof(Artist.FullName);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort);
            builder.SaveRouteSegments();

            var options = new QueryOptions<Artist> {
                Includes = "AlbumArtists.Album",
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderByDirection = builder.CurrentRoute.SortDirection
            };
            if (builder.CurrentRoute.SortField.EqualsNoCase(defaultSort))
                options.OrderBy = a => a.FullName;

            var vm = new GridViewModel<Artist> {
                Items = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count)
            };

            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var artist = data.Get(new QueryOptions<Artist> {
                Includes = "AlbumArtists.Album",
                Where = a => a.ArtistId == id
            });
            return View(artist);
        }
    }
}