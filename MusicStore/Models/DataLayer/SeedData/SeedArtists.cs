using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicStore.Models
{
    internal class SeedArtists : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entity)
        {
            entity.HasData(
                new Artist { ArtistId = 1, FullName = "Various Artists" },
                new Artist { ArtistId = 2, FullName = "Kelly Clarkson" },
                new Artist { ArtistId = 3, FullName = "Taylor Swift" },
                new Artist { ArtistId = 4, FullName = "ITZY" },
                new Artist { ArtistId = 5, FullName = "The Maine" },
                new Artist
                {
                    ArtistId = 6,
                    FullName =
                        "Yasunori Mitsuda / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Mariam Abounnasr / Yutaka Kunigo"
                },
                new Artist { ArtistId = 7, FullName = "Eagles" },
                new Artist { ArtistId = 8, FullName = "Sinéad O'Connor" },
                new Artist { ArtistId = 9, FullName = "Luke Combs" },
                new Artist { ArtistId = 10, FullName = "Lainey Wilson" },
                new Artist { ArtistId = 11, FullName = "Joni Mitchell" },
                new Artist { ArtistId = 12, FullName = "Masayoshi Soken" },
                new Artist { ArtistId = 13, FullName = "Ludwig Göransson" },
                new Artist { ArtistId = 14, FullName = "Old Dominion" },
                new Artist { ArtistId = 15, FullName = "NewJeans" },
                new Artist
                {
                    ArtistId = 16,
                    FullName =
                        "Yoko Shimomura / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Yasunori Mitsuda"
                },
                new Artist { ArtistId = 17, FullName = "Ed Sheeran" },
                new Artist { ArtistId = 18, FullName = "Journey" },
                new Artist { ArtistId = 19, FullName = "Chris Stapleton" },
                new Artist { ArtistId = 20, FullName = "Tori Kelly" },
                new Artist { ArtistId = 21, FullName = "Creedence Clearwater Revival" },
                new Artist { ArtistId = 22, FullName = "Greta Van Fleet" },
                new Artist { ArtistId = 23, FullName = "Imagine Dragons" },
                new Artist { ArtistId = 24, FullName = "October London" },
                new Artist { ArtistId = 25, FullName = "Rokosi" },
                new Artist { ArtistId = 26, FullName = "NF" },
                new Artist { ArtistId = 27, FullName = "The Elovaters" },
                new Artist { ArtistId = 28, FullName = "xikers" },
                new Artist { ArtistId = 29, FullName = "Aphex Twin" },
                new Artist { ArtistId = 30, FullName = "Tracy Chapman" },
                new Artist { ArtistId = 31, FullName = "Bailey Zimmerman" },
                new Artist { ArtistId = 32, FullName = "INFINITE" },
                new Artist { ArtistId = 33, FullName = "Fleetwood Mac" },
                new Artist { ArtistId = 34, FullName = "The Beach Boys" },
                new Artist { ArtistId = 35, FullName = "Zach Bryan" },
                new Artist { ArtistId = 36, FullName = "ABBA" },
                new Artist { ArtistId = 37, FullName = "Metallica" },
                new Artist { ArtistId = 38, FullName = "Tyler Childers" },
                new Artist { ArtistId = 39, FullName = "Ghost Hounds" },
                new Artist { ArtistId = 40, FullName = "Sleep Token" },
                new Artist { ArtistId = 41, FullName = "Benj Pasek & Justin Paul" },
                new Artist { ArtistId = 42, FullName = "Hugh Jackman" },
                new Artist { ArtistId = 43, FullName = "Keala Settle" },
                new Artist { ArtistId = 44, FullName = "Zac Efron" },
                new Artist { ArtistId = 45, FullName = "Zendaya" },
                new Artist { ArtistId = 46, FullName = "The Beatles" },
                new Artist { ArtistId = 47, FullName = "Van Halen" },
                new Artist { ArtistId = 48, FullName = "Foo Fighters" },
                new Artist { ArtistId = 49, FullName = "Foreigner" },
                new Artist { ArtistId = 50, FullName = "America" },
                new Artist { ArtistId = 51, FullName = "Queen" },
                new Artist { ArtistId = 52, FullName = "Tom Petty & The Heartbreakers" },
                new Artist { ArtistId = 53, FullName = "Bob Marley & The Wailers" }
            );
        }
    }
}