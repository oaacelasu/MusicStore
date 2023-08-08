using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Album> data { get; set; }
        public HomeController(MusicStoreContext ctx) => data = new Repository<Album>(ctx);

        public ViewResult Index()
        {
            // empty collection
            var randomAlbums = new List<Album>();
            // get three random albums
            for (int i = 0; i < 3; i++)
            {
                var album = data.Get(new QueryOptions<Album> {
                    OrderBy = b => Guid.NewGuid(),
                    Includes = "Genre"
                });
                randomAlbums.Add(album);
            }
            return View(randomAlbums);
        }
    }
}