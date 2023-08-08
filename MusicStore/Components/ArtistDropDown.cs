using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Components
{
    public class ArtistDropDown : ViewComponent
    {
        private IRepository<Artist> data { get; set; }
        public ArtistDropDown(IRepository<Artist> rep) => data = rep;

        public IViewComponentResult Invoke(string selectedValue)
        {
            var artists = data.List(new QueryOptions<Artist> {
                OrderBy = a => a.FullName
            });
            
            var vm = new DropDownViewModel {
                SelectedValue = selectedValue,
                DefaultValue = AlbumsGridDTO.DefaultFilter,
                Items = artists.ToDictionary(
                    a => a.ArtistId.ToString(), a => a.FullName)
            };

            return View(SharedPath.Select, vm);
        }
    }
}
