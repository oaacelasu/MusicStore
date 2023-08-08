using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicStore.Models
{
    internal class SeedAlbums : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> entity)
        {
            entity.HasData(
                new Album
                {
                    AlbumId = 1,
                    Title = "Barbie The Album",
                    GenreId = "pop",
                    Price = 10.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/c0/54/97/c05497aa-c19f-bf4f-de29-71edf30fbefb/075679688767.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 21),
                },
                new Album
                {
                    AlbumId = 2,
                    Title = "chemistry",
                    GenreId = "pop",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/5e/3f/00/5e3f0031-5753-bd87-93e7-cdc9a479928b/075679690432.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 6, 23),
                },
                new Album
                {
                    AlbumId = 3,
                    Title = "Speak Now (Taylor's Version)",
                    GenreId = "country",
                    Price = 13.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/3b/02/ea/3b02ea2d-2586-59d7-d2b8-e9b6af6b52b3/23UMGIM63932.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 7),
                },
                new Album
                {
                    AlbumId = 4,
                    Title = "KILL MY DOUBT - EP",
                    GenreId = "kpop",
                    Price = 5.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/50/e3/e0/50e3e0a3-d11c-d277-de39-a672a258ed4b/8809928950990_Cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 31),
                },
                new Album
                {
                    AlbumId = 5,
                    Title = "Lover",
                    GenreId = "pop",
                    Price = 11.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music125/v4/49/3d/ab/493dab54-f920-9043-6181-80993b8116c9/19UMGIM53909.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2019, 8, 23),
                },
                new Album
                {
                    AlbumId = 6,
                    Title = "The Maine",
                    GenreId = "alternative",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/6c/d6/97/6cd69741-63e0-d56b-3bf2-902606b43f1b/23SYMIM05048.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 8, 1),
                },
                new Album
                {
                    AlbumId = 7,
                    Title = "Xenoblade Chronicles 3 (Original Soundtrack)",
                    GenreId = "videogame",
                    Price = 44.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/f8/6c/c8/f86cc8e6-69fa-b811-85f0-b72f90aa54f1/PA00120119_1_167817_jacket.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 8, 2),
                },
                new Album
                {
                    AlbumId = 8,
                    Title = "Their Greatest Hits 1971-1975",
                    GenreId = "rock",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/f0/c7/c8/f0c7c8f4-4319-d357-ddaf-566ef8e2194e/081227979379.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1976, 2, 17),
                },
                new Album
                {
                    AlbumId = 9,
                    Title = "I Do Not Want What I Haven't Got",
                    GenreId = "alternative",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music122/v4/76/43/92/764392cc-de5e-eadd-8ccc-ba0e3ec04401/5054526647565.png/170x170bb.png",
                    ReleaseDate = new DateTime(1990, 3, 20),
                },
                new Album
                {
                    AlbumId = 10,
                    Title = "Gettin' Old",
                    GenreId = "country",
                    Price = 13.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music113/v4/7d/24/14/7d241439-671a-d957-9613-2f738f43a064/196589485991.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 3, 24),
                },
                new Album
                {
                    AlbumId = 11,
                    Title = "Fearless (Taylor's Version)",
                    GenreId = "country",
                    Price = 13.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music125/v4/c3/d0/1c/c3d01c88-73e7-187e-fd62-e1744de979a6/21UMGIM09915.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2021, 4, 9)
                },
                new Album
                {
                    AlbumId = 12,
                    Title = "The Lion and the Cobra",
                    GenreId = "pop",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music122/v4/3e/c8/00/3ec80000-5f41-b9d4-0ccd-6350fa102fb1/5054526780682.png/170x170bb.png",
                    ReleaseDate = new DateTime(1987, 11, 4),
                },
                new Album
                {
                    AlbumId = 13,
                    Title =
                        "Guardians of the Galaxy, Vol. 3: Awesome Mix, Vol. 3 (Original Motion Picture Soundtrack)",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/2e/02/1d/2e021d5b-9ebe-91a6-7cc4-98c502203a59/23UMGIM44883.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 5, 3),
                },
                new Album
                {
                    AlbumId = 14,
                    Title = "reputation",
                    GenreId = "pop",
                    Price = 9.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/ba/16/42/ba1642a8-0c75-a83d-3b9c-8c2eba140dc5/00843930033133.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2017, 11, 10),
                },
                new Album
                {
                    AlbumId = 15,
                    Title = "Bell Bottom Country",
                    GenreId = "country",
                    Price = 10.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music112/v4/2c/d4/d1/2cd4d14d-d89c-d7d5-8ae7-bbca55e23c4f/4050538875423.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2022, 11, 28),
                },
                new Album
                {
                    AlbumId = 16,
                    Title = "Barbie The Album (Best Weekend Ever Edition)",
                    GenreId = "pop",
                    Price = 11.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/b7/0a/bc/b70abcc1-b835-99c5-ea32-6fee2155605a/075679675002.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 21),
                },
                new Album
                {
                    AlbumId = 17,
                    Title = "Joni Mitchell at Newport (Live)",
                    GenreId = "singersongwriter",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/b5/3b/9f/b53b9fa9-8ef9-72b3-f34b-289d93d62a00/603497832095.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28),
                },
                new Album
                {
                    AlbumId = 18,
                    Title = "FINAL FANTASY XVI Original Soundtrack",
                    GenreId = "soundtrack",
                    Price = 35.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/84/24/ce/8424cefe-738c-4c9d-fb18-6e86d36399fe/SQEX-11039-1_3000x3000.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 19),
                },
                new Album
                {
                    AlbumId = 19,
                    Title = "Oppenheimer (Original Motion Picture Soundtrack)",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/27/fa/ca/27faca2e-7f7a-cf17-ae3e-647294d52713/697.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 21),
                },
                new Album
                {
                    AlbumId = 20,
                    Title = "Memory Lane",
                    GenreId = "country",
                    Price = 6.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/98/5a/09/985a0908-223c-c3e3-8175-fa2abc241302/196871169363.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 6, 23),
                },
                // ... Previous albums ...
                new Album
                {
                    AlbumId = 21,
                    Title = "NewJeans 2nd EP 'Get Up'",
                    GenreId = "kpop",
                    Price = 4.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/d3/4b/7e/d34b7e1e-af3b-43b6-2949-7a8c652a1bc9/196922462726_Cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 21)
                },
                new Album
                {
                    AlbumId = 22,
                    Title = "Xenoblade Chronicles: Definitive Edition (Original Soundtrack)",
                    GenreId = "videogame",
                    Price = 29.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/e7/43/b4/e743b4c6-10fb-f366-52b4-92094b879fd6/PA00120120_1_167816_jacket.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 8, 2)
                },
                new Album
                {
                    AlbumId = 23,
                    Title = "- (Deluxe)",
                    GenreId = "pop",
                    Price = 9.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music126/v4/c2/4c/36/c24c3631-08b8-b576-345a-259b395f8dbd/5054197591464.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 5, 5)
                },
                new Album
                {
                    AlbumId = 24,
                    Title = "Speak Now (Taylor's Version)",
                    GenreId = "country",
                    Price = 13.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/9f/3c/0a/9f3c0a60-f9e0-a34e-60e5-0be1f182896b/23UMGIM63932.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 7)
                },
                new Album
                {
                    AlbumId = 25,
                    Title = "Greatest Hits",
                    GenreId = "rock",
                    Price = 10.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/cd/43/e7/cd43e76f-4ff1-f700-d84f-86eeea7fa5bb/828768588925.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1988, 11, 15)
                },
                new Album
                {
                    AlbumId = 26,
                    Title = "Starting Over",
                    GenreId = "country",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/34/12/78/34127801-ad2b-4469-4916-d661bba34a94/20UMGIM71875.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2020, 11, 13)
                },
                new Album
                {
                    AlbumId = 27,
                    Title = "tori",
                    GenreId = "pop",
                    Price = 6.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music116/v4/09/e3/d0/09e3d0f2-2dac-c8a6-c203-e53cab676343/196871273671.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 28,
                    Title = "So Far… The Best of Sinéad O'Connor",
                    GenreId = "pop",
                    Price = 11.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music112/v4/60/10/80/601080b3-b9f6-2eaa-d74e-d4098d39fe7e/5054526649187.png/170x170bb.png",
                    ReleaseDate = new DateTime(1997, 11, 25)
                },
                new Album
                {
                    AlbumId = 29,
                    Title = "NOW That's What I Call Classic Rock",
                    GenreId = "rock",
                    Price = 7.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music112/v4/2f/0a/fb/2f0afb49-2e70-3b52-95ce-29b3775ef1fe/196589493545.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2022, 10, 28)
                },
                new Album
                {
                    AlbumId = 30,
                    Title = "Chronicle: The 20 Greatest Hits",
                    GenreId = "rock",
                    Price = 11.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/a1/47/ba/a147ba91-31cd-ef4d-d785-040036d14598/12CMGIM34362.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1976, 1, 1)
                },
                // ... Previous albums ...
                new Album
                {
                    AlbumId = 31,
                    Title = "1989",
                    GenreId = "pop",
                    Price = 10.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music115/v4/09/01/16/090116af-770e-23da-21a9-6bd30782eda5/00843930013562.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2014, 10, 27)
                },
                new Album
                {
                    AlbumId = 32,
                    Title = "Starcatcher",
                    GenreId = "rock",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/34/ee/21/34ee21ae-e18d-6195-dc02-65d2344d23c9/23UMGIM36455.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 21)
                },
                new Album
                {
                    AlbumId = 33,
                    Title = "Guardians of the Galaxy: Awesome Mix, Vol. 1 (Original Motion Picture Soundtrack)",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music114/v4/3b/46/fe/3b46fe36-3fc6-8aca-8953-71f504fd0222/14DMGIM05236.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2014, 1, 1)
                },
                new Album
                {
                    AlbumId = 34,
                    Title = "Evolve",
                    GenreId = "alternative",
                    Price = 6.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/11/7a/b8/117ab805-6811-8929-18b9-0fad7baf0c25/17UMGIM98210.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2017, 6, 23)
                },
                new Album
                {
                    AlbumId = 35,
                    Title = "The Rebirth of Marvin",
                    GenreId = "rbsoul",
                    Price = 10.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/e9/a8/ec/e9a8ec80-24fd-4d8d-3823-ac87e5f71104/cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 2, 10)
                },
                new Album
                {
                    AlbumId = 36,
                    Title = "June 22 - EP",
                    GenreId = "rbsoul",
                    Price = 5.16,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/60/47/31/604731b0-89c3-2ddb-e4c5-98285e99ce4b/196282898050.png/170x170bb.png",
                    ReleaseDate = new DateTime(2021, 9, 17)
                },
                new Album
                {
                    AlbumId = 37,
                    Title = "HOPE",
                    GenreId = "hiphoprap",
                    Price = 9.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/5a/6d/1a/5a6d1a4e-ac13-c7e8-1eba-e80a35651622/23UMGIM07672.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 4, 7)
                },
                new Album
                {
                    AlbumId = 38,
                    Title = "Endless Summer",
                    GenreId = "reggae",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/f6/03/94/f6039435-7be4-ec98-e791-73104a7e593f/197773096986_cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 39,
                    Title = "HOUSE OF TRICKY : HOW TO PLAY - EP",
                    GenreId = "kpop",
                    Price = 5.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/54/dd/b4/54ddb472-761d-3a04-bf74-ec81c5106d31/cover_KM0017975_1.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 8, 2)
                },
                new Album
                {
                    AlbumId = 40,
                    Title = "Traveller",
                    GenreId = "country",
                    Price = 9.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music125/v4/e2/4b/60/e24b6016-8278-bb18-cf5d-d44bf68371da/00602547223838.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2015, 5, 5)
                },
                new Album
                {
                    AlbumId = 41,
                    Title = "RWBY, Vol. 9 (Music from the Rooster Teeth Series)",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/06/26/23/0626234a-12a7-7139-02d0-a3a70a406c49/859775800151_cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 42,
                    Title = "Blackbox Life Recorder 21f / In a Room7 F760 - EP",
                    GenreId = "electronic",
                    Price = 3.96,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/c3/ee/ab/c3eeab38-a108-2eb2-b432-97db4cef4f6a/5056614706703.png/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 43,
                    Title = "Tracy Chapman",
                    GenreId = "singersongwriter",
                    Price = 6.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music125/v4/2a/c1/cf/2ac1cf24-2a07-c62e-921c-357aba15d7f4/mzi.vosghqus.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1988, 4, 5)
                },
                new Album
                {
                    AlbumId = 44,
                    Title = "Religiously. The Album.",
                    GenreId = "country",
                    Price = 9.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music116/v4/1d/a3/55/1da35509-ea85-d568-d29d-83e464f53ff9/093624856498.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 5, 12)
                },
                new Album
                {
                    AlbumId = 45,
                    Title = "13egin - EP",
                    GenreId = "kpop",
                    Price = 5.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/09/bc/96/09bc9676-b952-20d8-ea7d-cfa6bedbac77/cover_KM0017967_1.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 31)
                },
                new Album
                {
                    AlbumId = 46,
                    Title = "Greatest Hits",
                    GenreId = "rock",
                    Price = 11.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music115/v4/d2/48/f4/d248f4ae-a7e4-a48e-1588-6617de3e8d76/mzi.izeorbmm.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1988, 11, 15)
                },
                new Album
                {
                    AlbumId = 47,
                    Title = "Greatest Hits",
                    GenreId = "rock",
                    Price = 7.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music112/v4/57/6f/c7/576fc76a-2eb4-11b1-a5dd-ad2aee4cdf0f/13UABIM04230.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2012, 10, 9)
                },
                new Album
                {
                    AlbumId = 48,
                    Title = "Summertime Blues - EP",
                    GenreId = "country",
                    Price = 7.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music112/v4/be/ea/e9/beeae98a-33a4-6e1d-6efc-b8dd098b0a2c/093624866459.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2022, 7, 15)
                },
                new Album
                {
                    AlbumId = 49,
                    Title = "The Very Best of Eagles",
                    GenreId = "rock",
                    Price = 27.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/88/90/0d/88900ddb-b23e-c1e6-8147-20eb92340076/081227397128.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2003, 10, 21)
                },
                new Album
                {
                    AlbumId = 50,
                    Title = "ABBA Gold: Greatest Hits",
                    GenreId = "pop",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/60/f8/a6/60f8a6bc-e875-238d-f2f8-f34a6034e6d2/14UMGIM07615.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1992, 9, 21)
                },
                new Album
                {
                    AlbumId = 51,
                    Title = "72 Seasons",
                    GenreId = "metal",
                    Price = 11.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/f7/50/56/f75056b7-d390-d215-51c5-3695dc6fe468/810083961095.png/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 4, 14)
                },
                new Album
                {
                    AlbumId = 52,
                    Title = "Can I Take My Hounds to Heaven?",
                    GenreId = "country",
                    Price = 11.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music122/v4/25/7c/f2/257cf2e2-6c7a-3212-1b27-a684cf85a62c/196589083906.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2022, 9, 30)
                },
                new Album
                {
                    AlbumId = 53,
                    Title = "First Last Time",
                    GenreId = "rock",
                    Price = 11.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music126/v4/8d/71/f1/8d71f1e2-4457-34c5-b214-a6d992b0777c/8720996002919.png/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 54,
                    Title = "Take Me Back To Eden",
                    GenreId = "metal",
                    Price = 9.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/e2/c6/0f/e2c60f68-7cec-fa08-6dd3-891aa72c247e/5401148000849_cover.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 5, 19)
                },
                new Album
                {
                    AlbumId = 55,
                    Title = "The Greatest Showman (Original Motion Picture Soundtrack)",
                    GenreId = "musicals",
                    Price = 9.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music115/v4/a6/63/54/a6635418-7d49-b237-d1c9-ba85fa57dbc6/075679886613.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2017, 12, 8)
                },
                new Album
                {
                    AlbumId = 56,
                    Title = "Metallica",
                    GenreId = "metal",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music125/v4/18/93/db/1893db5c-ddd1-b95c-3112-b9b83bcceab0/0093624986553.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1991, 8, 12)
                },
                new Album
                {
                    AlbumId = 57,
                    Title = "1",
                    GenreId = "rock",
                    Price = 12.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/f2/98/fb/f298fb48-1e0e-6ad4-4cff-fb824b77f02e/15UMGIM59587.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2000, 11, 13)
                },
                new Album
                {
                    AlbumId = 58,
                    Title = "NOW That's What I Call '90s Alternative Rock",
                    GenreId = "rock",
                    Price = 7.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music112/v4/91/03/14/9103142e-9c42-3658-4d89-5f786ec5fdf1/196589142092.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2022, 8, 5)
                },
                new Album
                {
                    AlbumId = 59,
                    Title = "NOW That's What I Call A Decade! The 80s",
                    GenreId = "pop",
                    Price = 6.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/91/dc/dc/91dcdcc0-0844-5257-e89c-fceba19673bc/886449239580.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2021, 8, 6)
                },
                new Album
                {
                    AlbumId = 60,
                    Title = "NOW That's What I Call the '80s",
                    GenreId = "pop",
                    Price = 6.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/4d/6f/51/4d6f518a-aed8-17fe-6727-ea26b2185ee4/888880473011.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2008, 3, 11)
                }, new Album
                {
                    AlbumId = 61,
                    Title =
                        "Guardians of the Galaxy, Vol. 2 (Original Motion Picture Soundtrack) [Awesome Mix, Vol. 2]",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music118/v4/cb/59/f4/cb59f4e3-69b5-f95c-cc5d-22637b29e139/00050087368777.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2017, 4, 21)
                },
                new Album
                {
                    AlbumId = 62,
                    Title = "1984",
                    GenreId = "hardrock",
                    Price = 6.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/79/98/f7/7998f761-20e0-aa8e-4fb2-190062af1638/603497894161.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1984, 1, 9)
                },
                new Album
                {
                    AlbumId = 63,
                    Title = "But Here We Are",
                    GenreId = "rock",
                    Price = 10.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/50/41/c9/5041c992-e078-77c1-442a-ff896abd59db/196871063197.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 6, 2)
                },
                new Album
                {
                    AlbumId = 64,
                    Title = "Miraculous: Ladybug & Cat Noir, The Movie (Original Motion Picture Soundtrack)",
                    GenreId = "soundtrack",
                    Price = 9.99,
                    Image =
                        "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/3a/2e/50/3a2e50ad-9e5b-8070-5b32-9684772b78c2/780163645224.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2023, 7, 28)
                },
                new Album
                {
                    AlbumId = 65,
                    Title = "No End In Sight: The Very Best of Foreigner (Remastered)",
                    GenreId = "rock",
                    Price = 17.99,
                    Image =
                        "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/af/7b/a2/af7ba295-c0c0-ba8d-17da-5cc52959a602/mzi.ykpmzuxm.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2008, 7, 15)
                },
                new Album
                {
                    AlbumId = 66,
                    Title = "America's Greatest Hits: History",
                    GenreId = "rock",
                    Price = 9.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music114/v4/ad/d9/22/add9226e-9c33-246b-e528-a1a96d05df48/mzi.onpokbmx.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1975, 10, 24)
                },
                new Album
                {
                    AlbumId = 67,
                    Title = "Greatest Hits I, II & III: The Platinum Collection",
                    GenreId = "rock",
                    Price = 24.99,
                    Image =
                        "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/4d/08/2a/4d082a9e-7898-1aa1-a02f-339810058d9e/14DMGIM05632.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(2000, 11, 13)
                },
                new Album
                {
                    AlbumId = 68,
                    Title = "Greatest Hits",
                    GenreId = "rock",
                    Price = 9.99,
                    Image =
                        "https://is4-ssl.mzstatic.com/image/thumb/Music112/v4/78/61/dd/7861dd44-f796-08ea-c8ff-7f8a12a86db1/15UMGIM69649.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1993, 11, 16)
                },
                new Album
                {
                    AlbumId = 69,
                    Title = "Legend – The Best of Bob Marley & The Wailers (2002 Edition)",
                    GenreId = "reggae",
                    Price = 9.99,
                    Image =
                        "https://is3-ssl.mzstatic.com/image/thumb/Music113/v4/ea/20/06/ea2006f9-7512-cf9c-7b44-78116156875e/12UMGIM14712.rgb.jpg/170x170bb.png",
                    ReleaseDate = new DateTime(1984, 5, 8)
                }
            );
        }
    }
}