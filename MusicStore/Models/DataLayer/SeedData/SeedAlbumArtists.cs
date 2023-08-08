using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicStore.Models
{
    internal class SeedAlbumArtists : IEntityTypeConfiguration<AlbumArtist>
    {
        public void Configure(EntityTypeBuilder<AlbumArtist> entity)
        {
            entity.HasData(
                new AlbumArtist { AlbumId = 1, ArtistId = 1 }, // Barbie The Album: Various Artists
                new AlbumArtist { AlbumId = 2, ArtistId = 2 }, // chemistry: Kelly Clarkson
                new AlbumArtist { AlbumId = 3, ArtistId = 3 }, // Speak Now (Taylor's Version): Taylor Swift
                new AlbumArtist { AlbumId = 4, ArtistId = 4 }, // KILL MY DOUBT - EP: ITZY
                new AlbumArtist { AlbumId = 5, ArtistId = 3 }, // Lover: Taylor Swift
                new AlbumArtist { AlbumId = 6, ArtistId = 5 }, // The Maine: The Maine
                new AlbumArtist
                {
                    AlbumId = 7, ArtistId = 6
                }, // Xenoblade Chronicles 3 (Original Soundtrack): Yasunori Mitsuda / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Mariam Abounnasr / Yutaka Kunigo
                new AlbumArtist { AlbumId = 8, ArtistId = 7 }, // Their Greatest Hits 1971-1975: Eagles
                new AlbumArtist { AlbumId = 9, ArtistId = 8 }, // I Do Not Want What I Haven't Got: Sinéad O'Connor
                new AlbumArtist { AlbumId = 10, ArtistId = 9 }, // Gettin' Old: Luke Combs
                new AlbumArtist { AlbumId = 11, ArtistId = 10 }, // Fearless (Taylor's Version): Taylor Swift
                new AlbumArtist { AlbumId = 12, ArtistId = 8 }, // The Lion and the Cobra: Sinéad O'Connor
                new AlbumArtist
                {
                    AlbumId = 13, ArtistId = 1
                }, // Guardians of the Galaxy, Vol. 3: Awesome Mix, Vol. 3 (Original Motion Picture Soundtrack): Various Artists
                new AlbumArtist { AlbumId = 14, ArtistId = 10 }, // reputation: Taylor Swift
                new AlbumArtist { AlbumId = 15, ArtistId = 11 }, // Bell Bottom Country: Lainey Wilson
                new AlbumArtist
                    { AlbumId = 16, ArtistId = 1 }, // Barbie The Album (Best Weekend Ever Edition): Various Artists
                new AlbumArtist { AlbumId = 17, ArtistId = 11 }, // Joni Mitchell at Newport (Live): Joni Mitchell
                new AlbumArtist
                    { AlbumId = 18, ArtistId = 12 }, // FINAL FANTASY XVI Original Soundtrack: Masayoshi Soken
                new AlbumArtist
                {
                    AlbumId = 19, ArtistId = 13
                }, // Oppenheimer (Original Motion Picture Soundtrack): Ludwig Göransson
                new AlbumArtist { AlbumId = 20, ArtistId = 14 }, // Memory Lane: Old Dominion
                new AlbumArtist { AlbumId = 21, ArtistId = 15 }, // NewJeans 2nd EP 'Get Up': NewJeans
                new AlbumArtist
                {
                    AlbumId = 22, ArtistId = 7
                }, // Xenoblade Chronicles: Definitive Edition (Original Soundtrack): Yoko Shimomura / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Yasunori Mitsuda
                new AlbumArtist { AlbumId = 23, ArtistId = 17 }, // - (Deluxe): Ed Sheeran
                new AlbumArtist { AlbumId = 24, ArtistId = 3 }, // Speak Now (Taylor's Version): Taylor Swift
                new AlbumArtist { AlbumId = 25, ArtistId = 18 }, // Greatest Hits: Journey
                new AlbumArtist { AlbumId = 26, ArtistId = 19 }, // Starting Over: Chris Stapleton
                new AlbumArtist { AlbumId = 27, ArtistId = 20 }, // tori: Tori Kelly
                new AlbumArtist { AlbumId = 28, ArtistId = 8 }, // So Far… The Best of Sinéad O'Connor: Sinéad O'Connor
                new AlbumArtist { AlbumId = 29, ArtistId = 1 }, // NOW That's What I Call Classic Rock: Various Artists
                new AlbumArtist
                    { AlbumId = 30, ArtistId = 21 }, // Chronicle: The 20 Greatest Hits: Creedence Clearwater Revival
                new AlbumArtist { AlbumId = 31, ArtistId = 3 }, // 1989: Taylor Swift
                new AlbumArtist { AlbumId = 32, ArtistId = 22 }, // Starcatcher: Greta Van Fleet
                new AlbumArtist
                {
                    AlbumId = 33, ArtistId = 1
                }, // Guardians of the Galaxy: Awesome Mix, Vol. 1 (Original Motion Picture Soundtrack): Various Artists
                new AlbumArtist { AlbumId = 34, ArtistId = 23 }, // Evolve: Imagine Dragons
                new AlbumArtist { AlbumId = 35, ArtistId = 24 }, // The Rebirth of Marvin: October London
                new AlbumArtist { AlbumId = 36, ArtistId = 25 }, // June 22 - EP: Rokosi
                new AlbumArtist { AlbumId = 37, ArtistId = 26 }, // HOPE: NF
                new AlbumArtist { AlbumId = 38, ArtistId = 27 }, // Endless Summer: The Elovaters
                new AlbumArtist { AlbumId = 39, ArtistId = 28 }, // HOUSE OF TRICKY : HOW TO PLAY - EP: xikers
                new AlbumArtist { AlbumId = 40, ArtistId = 19 }, // Traveller: Chris Stapleton
                new AlbumArtist
                {
                    AlbumId = 41, ArtistId = 1
                }, // Rwby, Vol. 9 (Music from the Rooster Teeth Series): Various Artists
                new AlbumArtist
                    { AlbumId = 42, ArtistId = 29 }, // Blackbox Life Recorder 21f / In a Room7 F760 - EP: Aphex Twin
                new AlbumArtist { AlbumId = 43, ArtistId = 30 }, // Tracy Chapman: Tracy Chapman
                new AlbumArtist { AlbumId = 44, ArtistId = 31 }, // Religiously. The Album.: Bailey Zimmerman
                new AlbumArtist { AlbumId = 45, ArtistId = 32 }, // 13egin - EP: INFINITE
                new AlbumArtist { AlbumId = 46, ArtistId = 33 }, // Greatest Hits: Fleetwood Mac
                new AlbumArtist { AlbumId = 47, ArtistId = 34 }, // Greatest Hits: The Beach Boys
                new AlbumArtist { AlbumId = 48, ArtistId = 35 }, // Summertime Blues - EP: Zach Bryan
                new AlbumArtist { AlbumId = 49, ArtistId = 7 }, // The Very Best of Eagles: Eagles
                new AlbumArtist { AlbumId = 50, ArtistId = 36 }, // ABBA Gold: Greatest Hits: ABBA
                new AlbumArtist { AlbumId = 51, ArtistId = 37 }, // 72 Seasons: Metallica
                new AlbumArtist { AlbumId = 52, ArtistId = 38 }, // Can I Take My Hounds to Heaven?: Tyler Childers
                new AlbumArtist { AlbumId = 53, ArtistId = 39 }, // First Last Time: Ghost Hounds
                new AlbumArtist { AlbumId = 54, ArtistId = 40 }, // Take Me Back To Eden: Sleep Token
                new AlbumArtist
                {
                    AlbumId = 55, ArtistId = 41
                }, // The Greatest Showman (Original Motion Picture Soundtrack): Benj Pasek & Justin Paul, Hugh Jackman, Keala Settle, Zac Efron, Zendaya
                new AlbumArtist { AlbumId = 56, ArtistId = 37 }, // Metallica: Metallica
                new AlbumArtist { AlbumId = 57, ArtistId = 42 }, // 1: The Beatles
                new AlbumArtist
                    { AlbumId = 58, ArtistId = 1 }, // NOW That's What I Call '90s Alternative Rock: Various Artists
                new AlbumArtist
                    { AlbumId = 59, ArtistId = 1 }, // NOW That's What I Call A Decade! The 80s: Various Artists
                new AlbumArtist { AlbumId = 60, ArtistId = 1 }, // NOW That's What I Call the '80s: Various Artists
                new AlbumArtist
                {
                    AlbumId = 61, ArtistId = 1
                }, // Guardians of the Galaxy, Vol. 2 (Original Motion Picture Soundtrack) [Awesome Mix, Vol. 2]: Various Artists
                new AlbumArtist { AlbumId = 62, ArtistId = 43 }, // 1984: Van Halen
                new AlbumArtist { AlbumId = 63, ArtistId = 44 }, // But Here We Are: Foo Fighters
                new AlbumArtist
                {
                    AlbumId = 64, ArtistId = 1
                }, // Miraculous: Ladybug & Cat Noir, The Movie (Original Motion Picture Soundtrack): Various Artists
                new AlbumArtist
                {
                    AlbumId = 65, ArtistId = 49
                }, // No End In Sight: The Very Best of Foreigner (Remastered): Foreigner
                new AlbumArtist { AlbumId = 66, ArtistId = 50 }, // America's Greatest Hits: History: America
                new AlbumArtist
                    { AlbumId = 67, ArtistId = 51 }, // Greatest Hits I, II & III: The Platinum Collection: Queen
                new AlbumArtist { AlbumId = 68, ArtistId = 52 }, // Greatest Hits: Tom Petty & The Heartbreakers
                new AlbumArtist
                {
                    AlbumId = 69, ArtistId = 53
                } // Legend – The Best of Bob Marley & The Wailers (2002 Edition): Bob Marley & The Wailers
            );
        }
    }
}