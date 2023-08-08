using System.Linq;

namespace MusicStore.Models
{
    public class AlbumQueryOptions : QueryOptions<Album>
    {
        public void SortFilter(AlbumsGridBuilder builder)
        {
            if (builder.IsFilterByGenre) {
                Where = b => b.GenreId == builder.CurrentRoute.GenreFilter;
            }
            if (builder.IsFilterByPrice) {
                if (builder.CurrentRoute.PriceFilter == "under7")
                    Where = b => b.Price < 7;
                else if (builder.CurrentRoute.PriceFilter == "7to14")
                    Where = b => b.Price >= 7 && b.Price <= 14;
                else
                    Where = b => b.Price > 14;
            }
            if (builder.IsFilterByArtist) {
                int id = builder.CurrentRoute.ArtistFilter.ToInt();
                if (id > 0)
                    Where = b => b.AlbumArtists.Any(ba => ba.Artist.ArtistId == id);
            }

            if (builder.IsSortByGenre) {
                OrderBy = b => b.Genre.Name;
            }
            else if (builder.IsSortByPrice) {
                OrderBy = b => b.Price;
            }
            else  {
                OrderBy = b => b.Title;
            }
        }
    }
}
