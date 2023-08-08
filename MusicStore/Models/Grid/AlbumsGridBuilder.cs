using Microsoft.AspNetCore.Http;

namespace MusicStore.Models
{
    public class AlbumsGridBuilder : GridBuilder
    {
        public AlbumsGridBuilder(ISession sess) : base(sess) { }

        public AlbumsGridBuilder(ISession sess, AlbumsGridDTO values, 
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            bool isInitial = values.Genre.IndexOf(FilterPrefix.Genre) == -1;
            routes.ArtistFilter = (isInitial) ? FilterPrefix.Artist + values.Artist : values.Artist;
            routes.GenreFilter = (isInitial) ? FilterPrefix.Genre + values.Genre : values.Genre;
            routes.PriceFilter = (isInitial) ? FilterPrefix.Price + values.Price : values.Price;
        }

        public void LoadFilterSegments(string[] filter, Artist artist)
        {
            if (artist == null) { 
                routes.ArtistFilter = FilterPrefix.Artist + filter[0];
            } else {
                routes.ArtistFilter = FilterPrefix.Artist + filter[0]
                    + "-" + artist.FullName.Slug();
            }
            routes.GenreFilter = FilterPrefix.Genre + filter[1];
            routes.PriceFilter = FilterPrefix.Price + filter[2];
        }
        public void ClearFilterSegments() => routes.ClearFilters();

        string def = AlbumsGridDTO.DefaultFilter;   
        public bool IsFilterByArtist => routes.ArtistFilter != def;
        public bool IsFilterByGenre => routes.GenreFilter != def;
        public bool IsFilterByPrice => routes.PriceFilter != def;

        public bool IsSortByGenre =>
            routes.SortField.EqualsNoCase(nameof(Genre));
        public bool IsSortByPrice =>
            routes.SortField.EqualsNoCase(nameof(Album.Price));
    }
}
