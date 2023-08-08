using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicStore.Models
{
    internal class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = "pop", Name = "Pop" },
                new Genre { GenreId = "country", Name = "Country" },
                new Genre { GenreId = "kpop", Name = "K-Pop" },
                new Genre { GenreId = "alternative", Name = "Alternative" },
                new Genre { GenreId = "videogame", Name = "Video Game" },
                new Genre { GenreId = "rock", Name = "Rock" },
                new Genre { GenreId = "soundtrack", Name = "Soundtrack" },
                new Genre { GenreId = "singersongwriter", Name = "Singer/Songwriter" },
                new Genre { GenreId = "rbsoul", Name = "R&B/Soul" },
                new Genre { GenreId = "hiphoprap", Name = "Hip-Hop/Rap" },
                new Genre { GenreId = "reggae", Name = "Reggae" },
                new Genre { GenreId = "electronic", Name = "Electronic" },
                new Genre { GenreId = "metal", Name = "Metal" },
                new Genre { GenreId = "musicals", Name = "Musicals" },
                new Genre { GenreId = "hardrock", Name = "Hard Rock" }
            );
        }
    }
}
