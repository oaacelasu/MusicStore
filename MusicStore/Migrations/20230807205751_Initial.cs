using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumArtists",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumArtists", x => new { x.AlbumId, x.ArtistId });
                    table.ForeignKey(
                        name: "FK_AlbumArtists_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtists_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FullName" },
                values: new object[,]
                {
                    { 1, "Various Artists" },
                    { 2, "Kelly Clarkson" },
                    { 3, "Taylor Swift" },
                    { 4, "ITZY" },
                    { 5, "The Maine" },
                    { 6, "Yasunori Mitsuda / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Mariam Abounnasr / Yutaka Kunigo" },
                    { 7, "Eagles" },
                    { 8, "Sinéad O'Connor" },
                    { 9, "Luke Combs" },
                    { 10, "Lainey Wilson" },
                    { 11, "Joni Mitchell" },
                    { 12, "Masayoshi Soken" },
                    { 13, "Ludwig Göransson" },
                    { 14, "Old Dominion" },
                    { 15, "NewJeans" },
                    { 16, "Yoko Shimomura / ACE (TOMOri Kudo, CHiCO) / Kenji Hiramatsu / Manami Kiyota / Yasunori Mitsuda" },
                    { 17, "Ed Sheeran" },
                    { 18, "Journey" },
                    { 19, "Chris Stapleton" },
                    { 20, "Tori Kelly" },
                    { 21, "Creedence Clearwater Revival" },
                    { 22, "Greta Van Fleet" },
                    { 23, "Imagine Dragons" },
                    { 24, "October London" },
                    { 25, "Rokosi" },
                    { 26, "NF" },
                    { 27, "The Elovaters" },
                    { 28, "xikers" },
                    { 29, "Aphex Twin" },
                    { 30, "Tracy Chapman" },
                    { 31, "Bailey Zimmerman" },
                    { 32, "INFINITE" },
                    { 33, "Fleetwood Mac" },
                    { 34, "The Beach Boys" },
                    { 35, "Zach Bryan" },
                    { 36, "ABBA" },
                    { 37, "Metallica" },
                    { 38, "Tyler Childers" },
                    { 39, "Ghost Hounds" },
                    { 40, "Sleep Token" },
                    { 41, "Benj Pasek & Justin Paul" },
                    { 42, "Hugh Jackman" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FullName" },
                values: new object[,]
                {
                    { 43, "Keala Settle" },
                    { 44, "Zac Efron" },
                    { 45, "Zendaya" },
                    { 46, "The Beatles" },
                    { 47, "Van Halen" },
                    { 48, "Foo Fighters" },
                    { 49, "Foreigner" },
                    { 50, "America" },
                    { 51, "Queen" },
                    { 52, "Tom Petty & The Heartbreakers" },
                    { 53, "Bob Marley & The Wailers" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "alternative", "Alternative" },
                    { "country", "Country" },
                    { "electronic", "Electronic" },
                    { "hardrock", "Hard Rock" },
                    { "hiphoprap", "Hip-Hop/Rap" },
                    { "kpop", "K-Pop" },
                    { "metal", "Metal" },
                    { "musicals", "Musicals" },
                    { "pop", "Pop" },
                    { "rbsoul", "R&B/Soul" },
                    { "reggae", "Reggae" },
                    { "rock", "Rock" },
                    { "singersongwriter", "Singer/Songwriter" },
                    { "soundtrack", "Soundtrack" },
                    { "videogame", "Video Game" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "GenreId", "Image", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "pop", "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/c0/54/97/c05497aa-c19f-bf4f-de29-71edf30fbefb/075679688767.jpg/170x170bb.png", 10.99, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbie The Album" },
                    { 2, "pop", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/5e/3f/00/5e3f0031-5753-bd87-93e7-cdc9a479928b/075679690432.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "chemistry" },
                    { 3, "country", "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/3b/02/ea/3b02ea2d-2586-59d7-d2b8-e9b6af6b52b3/23UMGIM63932.rgb.jpg/170x170bb.png", 13.99, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speak Now (Taylor's Version)" },
                    { 4, "kpop", "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/50/e3/e0/50e3e0a3-d11c-d277-de39-a672a258ed4b/8809928950990_Cover.jpg/170x170bb.png", 5.9900000000000002, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "KILL MY DOUBT - EP" },
                    { 5, "pop", "https://is2-ssl.mzstatic.com/image/thumb/Music125/v4/49/3d/ab/493dab54-f920-9043-6181-80993b8116c9/19UMGIM53909.rgb.jpg/170x170bb.png", 11.99, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lover" },
                    { 6, "alternative", "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/6c/d6/97/6cd69741-63e0-d56b-3bf2-902606b43f1b/23SYMIM05048.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Maine" },
                    { 7, "videogame", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/f8/6c/c8/f86cc8e6-69fa-b811-85f0-b72f90aa54f1/PA00120119_1_167817_jacket.jpg/170x170bb.png", 44.990000000000002, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xenoblade Chronicles 3 (Original Soundtrack)" },
                    { 8, "rock", "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/f0/c7/c8/f0c7c8f4-4319-d357-ddaf-566ef8e2194e/081227979379.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1976, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Their Greatest Hits 1971-1975" },
                    { 9, "alternative", "https://is5-ssl.mzstatic.com/image/thumb/Music122/v4/76/43/92/764392cc-de5e-eadd-8ccc-ba0e3ec04401/5054526647565.png/170x170bb.png", 9.9900000000000002, new DateTime(1990, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "I Do Not Want What I Haven't Got" },
                    { 10, "country", "https://is2-ssl.mzstatic.com/image/thumb/Music113/v4/7d/24/14/7d241439-671a-d957-9613-2f738f43a064/196589485991.jpg/170x170bb.png", 13.99, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gettin' Old" },
                    { 11, "country", "https://is4-ssl.mzstatic.com/image/thumb/Music125/v4/c3/d0/1c/c3d01c88-73e7-187e-fd62-e1744de979a6/21UMGIM09915.rgb.jpg/170x170bb.png", 13.99, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fearless (Taylor's Version)" },
                    { 12, "pop", "https://is1-ssl.mzstatic.com/image/thumb/Music122/v4/3e/c8/00/3ec80000-5f41-b9d4-0ccd-6350fa102fb1/5054526780682.png/170x170bb.png", 9.9900000000000002, new DateTime(1987, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion and the Cobra" },
                    { 13, "soundtrack", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/2e/02/1d/2e021d5b-9ebe-91a6-7cc4-98c502203a59/23UMGIM44883.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy, Vol. 3: Awesome Mix, Vol. 3 (Original Motion Picture Soundtrack)" },
                    { 14, "pop", "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/ba/16/42/ba1642a8-0c75-a83d-3b9c-8c2eba140dc5/00843930033133.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2017, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "reputation" },
                    { 15, "country", "https://is5-ssl.mzstatic.com/image/thumb/Music112/v4/2c/d4/d1/2cd4d14d-d89c-d7d5-8ae7-bbca55e23c4f/4050538875423.jpg/170x170bb.png", 10.99, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bell Bottom Country" },
                    { 16, "pop", "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/b7/0a/bc/b70abcc1-b835-99c5-ea32-6fee2155605a/075679675002.jpg/170x170bb.png", 11.99, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbie The Album (Best Weekend Ever Edition)" },
                    { 17, "singersongwriter", "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/b5/3b/9f/b53b9fa9-8ef9-72b3-f34b-289d93d62a00/603497832095.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joni Mitchell at Newport (Live)" },
                    { 18, "soundtrack", "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/84/24/ce/8424cefe-738c-4c9d-fb18-6e86d36399fe/SQEX-11039-1_3000x3000.jpg/170x170bb.png", 35.990000000000002, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FINAL FANTASY XVI Original Soundtrack" },
                    { 19, "soundtrack", "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/27/fa/ca/27faca2e-7f7a-cf17-ae3e-647294d52713/697.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oppenheimer (Original Motion Picture Soundtrack)" },
                    { 20, "country", "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/98/5a/09/985a0908-223c-c3e3-8175-fa2abc241302/196871169363.jpg/170x170bb.png", 6.9900000000000002, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memory Lane" },
                    { 21, "kpop", "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/d3/4b/7e/d34b7e1e-af3b-43b6-2949-7a8c652a1bc9/196922462726_Cover.jpg/170x170bb.png", 4.9900000000000002, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "NewJeans 2nd EP 'Get Up'" },
                    { 22, "videogame", "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/e7/43/b4/e743b4c6-10fb-f366-52b4-92094b879fd6/PA00120120_1_167816_jacket.jpg/170x170bb.png", 29.989999999999998, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xenoblade Chronicles: Definitive Edition (Original Soundtrack)" },
                    { 23, "pop", "https://is4-ssl.mzstatic.com/image/thumb/Music126/v4/c2/4c/36/c24c3631-08b8-b576-345a-259b395f8dbd/5054197591464.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "- (Deluxe)" },
                    { 24, "country", "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/9f/3c/0a/9f3c0a60-f9e0-a34e-60e5-0be1f182896b/23UMGIM63932.rgb.jpg/170x170bb.png", 13.99, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speak Now (Taylor's Version)" },
                    { 25, "rock", "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/cd/43/e7/cd43e76f-4ff1-f700-d84f-86eeea7fa5bb/828768588925.jpg/170x170bb.png", 10.99, new DateTime(1988, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greatest Hits" },
                    { 26, "country", "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/34/12/78/34127801-ad2b-4469-4916-d661bba34a94/20UMGIM71875.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starting Over" },
                    { 27, "pop", "https://is2-ssl.mzstatic.com/image/thumb/Music116/v4/09/e3/d0/09e3d0f2-2dac-c8a6-c203-e53cab676343/196871273671.jpg/170x170bb.png", 6.9900000000000002, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tori" },
                    { 28, "pop", "https://is1-ssl.mzstatic.com/image/thumb/Music112/v4/60/10/80/601080b3-b9f6-2eaa-d74e-d4098d39fe7e/5054526649187.png/170x170bb.png", 11.99, new DateTime(1997, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "So Far… The Best of Sinéad O'Connor" },
                    { 29, "rock", "https://is5-ssl.mzstatic.com/image/thumb/Music112/v4/2f/0a/fb/2f0afb49-2e70-3b52-95ce-29b3775ef1fe/196589493545.jpg/170x170bb.png", 7.9900000000000002, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOW That's What I Call Classic Rock" },
                    { 30, "rock", "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/a1/47/ba/a147ba91-31cd-ef4d-d785-040036d14598/12CMGIM34362.rgb.jpg/170x170bb.png", 11.99, new DateTime(1976, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chronicle: The 20 Greatest Hits" },
                    { 31, "pop", "https://is3-ssl.mzstatic.com/image/thumb/Music115/v4/09/01/16/090116af-770e-23da-21a9-6bd30782eda5/00843930013562.rgb.jpg/170x170bb.png", 10.99, new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "1989" },
                    { 32, "rock", "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/34/ee/21/34ee21ae-e18d-6195-dc02-65d2344d23c9/23UMGIM36455.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starcatcher" },
                    { 33, "soundtrack", "https://is3-ssl.mzstatic.com/image/thumb/Music114/v4/3b/46/fe/3b46fe36-3fc6-8aca-8953-71f504fd0222/14DMGIM05236.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy: Awesome Mix, Vol. 1 (Original Motion Picture Soundtrack)" },
                    { 34, "alternative", "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/11/7a/b8/117ab805-6811-8929-18b9-0fad7baf0c25/17UMGIM98210.rgb.jpg/170x170bb.png", 6.9900000000000002, new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evolve" },
                    { 35, "rbsoul", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/e9/a8/ec/e9a8ec80-24fd-4d8d-3823-ac87e5f71104/cover.jpg/170x170bb.png", 10.99, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Rebirth of Marvin" },
                    { 36, "rbsoul", "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/60/47/31/604731b0-89c3-2ddb-e4c5-98285e99ce4b/196282898050.png/170x170bb.png", 5.1600000000000001, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "June 22 - EP" },
                    { 37, "hiphoprap", "https://is4-ssl.mzstatic.com/image/thumb/Music116/v4/5a/6d/1a/5a6d1a4e-ac13-c7e8-1eba-e80a35651622/23UMGIM07672.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HOPE" },
                    { 38, "reggae", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/f6/03/94/f6039435-7be4-ec98-e791-73104a7e593f/197773096986_cover.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Endless Summer" },
                    { 39, "kpop", "https://is5-ssl.mzstatic.com/image/thumb/Music126/v4/54/dd/b4/54ddb472-761d-3a04-bf74-ec81c5106d31/cover_KM0017975_1.jpg/170x170bb.png", 5.9900000000000002, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "HOUSE OF TRICKY : HOW TO PLAY - EP" },
                    { 40, "country", "https://is4-ssl.mzstatic.com/image/thumb/Music125/v4/e2/4b/60/e24b6016-8278-bb18-cf5d-d44bf68371da/00602547223838.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traveller" },
                    { 41, "soundtrack", "https://is1-ssl.mzstatic.com/image/thumb/Music126/v4/06/26/23/0626234a-12a7-7139-02d0-a3a70a406c49/859775800151_cover.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "RWBY, Vol. 9 (Music from the Rooster Teeth Series)" },
                    { 42, "electronic", "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/c3/ee/ab/c3eeab38-a108-2eb2-b432-97db4cef4f6a/5056614706703.png/170x170bb.png", 3.96, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blackbox Life Recorder 21f / In a Room7 F760 - EP" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "GenreId", "Image", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 43, "singersongwriter", "https://is5-ssl.mzstatic.com/image/thumb/Music125/v4/2a/c1/cf/2ac1cf24-2a07-c62e-921c-357aba15d7f4/mzi.vosghqus.jpg/170x170bb.png", 6.9900000000000002, new DateTime(1988, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tracy Chapman" },
                    { 44, "country", "https://is2-ssl.mzstatic.com/image/thumb/Music116/v4/1d/a3/55/1da35509-ea85-d568-d29d-83e464f53ff9/093624856498.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Religiously. The Album." },
                    { 45, "kpop", "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/09/bc/96/09bc9676-b952-20d8-ea7d-cfa6bedbac77/cover_KM0017967_1.jpg/170x170bb.png", 5.9900000000000002, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "13egin - EP" },
                    { 46, "rock", "https://is2-ssl.mzstatic.com/image/thumb/Music115/v4/d2/48/f4/d248f4ae-a7e4-a48e-1588-6617de3e8d76/mzi.izeorbmm.jpg/170x170bb.png", 11.99, new DateTime(1988, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greatest Hits" },
                    { 47, "rock", "https://is2-ssl.mzstatic.com/image/thumb/Music112/v4/57/6f/c7/576fc76a-2eb4-11b1-a5dd-ad2aee4cdf0f/13UABIM04230.rgb.jpg/170x170bb.png", 7.9900000000000002, new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greatest Hits" },
                    { 48, "country", "https://is4-ssl.mzstatic.com/image/thumb/Music112/v4/be/ea/e9/beeae98a-33a4-6e1d-6efc-b8dd098b0a2c/093624866459.jpg/170x170bb.png", 7.9900000000000002, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summertime Blues - EP" },
                    { 49, "rock", "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/88/90/0d/88900ddb-b23e-c1e6-8147-20eb92340076/081227397128.jpg/170x170bb.png", 27.989999999999998, new DateTime(2003, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Very Best of Eagles" },
                    { 50, "pop", "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/60/f8/a6/60f8a6bc-e875-238d-f2f8-f34a6034e6d2/14UMGIM07615.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1992, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABBA Gold: Greatest Hits" },
                    { 51, "metal", "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/f7/50/56/f75056b7-d390-d215-51c5-3695dc6fe468/810083961095.png/170x170bb.png", 11.99, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "72 Seasons" },
                    { 52, "country", "https://is4-ssl.mzstatic.com/image/thumb/Music122/v4/25/7c/f2/257cf2e2-6c7a-3212-1b27-a684cf85a62c/196589083906.jpg/170x170bb.png", 11.99, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can I Take My Hounds to Heaven?" },
                    { 53, "rock", "https://is4-ssl.mzstatic.com/image/thumb/Music126/v4/8d/71/f1/8d71f1e2-4457-34c5-b214-a6d992b0777c/8720996002919.png/170x170bb.png", 11.99, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Last Time" },
                    { 54, "metal", "https://is3-ssl.mzstatic.com/image/thumb/Music116/v4/e2/c6/0f/e2c60f68-7cec-fa08-6dd3-891aa72c247e/5401148000849_cover.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Take Me Back To Eden" },
                    { 55, "musicals", "https://is2-ssl.mzstatic.com/image/thumb/Music115/v4/a6/63/54/a6635418-7d49-b237-d1c9-ba85fa57dbc6/075679886613.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2017, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Greatest Showman (Original Motion Picture Soundtrack)" },
                    { 56, "metal", "https://is5-ssl.mzstatic.com/image/thumb/Music125/v4/18/93/db/1893db5c-ddd1-b95c-3112-b9b83bcceab0/0093624986553.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metallica" },
                    { 57, "rock", "https://is5-ssl.mzstatic.com/image/thumb/Music116/v4/f2/98/fb/f298fb48-1e0e-6ad4-4cff-fb824b77f02e/15UMGIM59587.rgb.jpg/170x170bb.png", 12.99, new DateTime(2000, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 58, "rock", "https://is3-ssl.mzstatic.com/image/thumb/Music112/v4/91/03/14/9103142e-9c42-3658-4d89-5f786ec5fdf1/196589142092.jpg/170x170bb.png", 7.9900000000000002, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOW That's What I Call '90s Alternative Rock" },
                    { 59, "pop", "https://is1-ssl.mzstatic.com/image/thumb/Music115/v4/91/dc/dc/91dcdcc0-0844-5257-e89c-fceba19673bc/886449239580.jpg/170x170bb.png", 6.9900000000000002, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOW That's What I Call A Decade! The 80s" },
                    { 60, "pop", "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/4d/6f/51/4d6f518a-aed8-17fe-6727-ea26b2185ee4/888880473011.jpg/170x170bb.png", 6.9900000000000002, new DateTime(2008, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOW That's What I Call the '80s" },
                    { 61, "soundtrack", "https://is1-ssl.mzstatic.com/image/thumb/Music118/v4/cb/59/f4/cb59f4e3-69b5-f95c-cc5d-22637b29e139/00050087368777.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2017, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy, Vol. 2 (Original Motion Picture Soundtrack) [Awesome Mix, Vol. 2]" },
                    { 62, "hardrock", "https://is3-ssl.mzstatic.com/image/thumb/Music125/v4/79/98/f7/7998f761-20e0-aa8e-4fb2-190062af1638/603497894161.jpg/170x170bb.png", 6.9900000000000002, new DateTime(1984, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 63, "rock", "https://is3-ssl.mzstatic.com/image/thumb/Music126/v4/50/41/c9/5041c992-e078-77c1-442a-ff896abd59db/196871063197.jpg/170x170bb.png", 10.99, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "But Here We Are" },
                    { 64, "soundtrack", "https://is2-ssl.mzstatic.com/image/thumb/Music126/v4/3a/2e/50/3a2e50ad-9e5b-8070-5b32-9684772b78c2/780163645224.jpg/170x170bb.png", 9.9900000000000002, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miraculous: Ladybug & Cat Noir, The Movie (Original Motion Picture Soundtrack)" },
                    { 65, "rock", "https://is1-ssl.mzstatic.com/image/thumb/Music125/v4/af/7b/a2/af7ba295-c0c0-ba8d-17da-5cc52959a602/mzi.ykpmzuxm.jpg/170x170bb.png", 17.989999999999998, new DateTime(2008, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "No End In Sight: The Very Best of Foreigner (Remastered)" },
                    { 66, "rock", "https://is5-ssl.mzstatic.com/image/thumb/Music114/v4/ad/d9/22/add9226e-9c33-246b-e528-a1a96d05df48/mzi.onpokbmx.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1975, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "America's Greatest Hits: History" },
                    { 67, "rock", "https://is5-ssl.mzstatic.com/image/thumb/Music115/v4/4d/08/2a/4d082a9e-7898-1aa1-a02f-339810058d9e/14DMGIM05632.rgb.jpg/170x170bb.png", 24.989999999999998, new DateTime(2000, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greatest Hits I, II & III: The Platinum Collection" },
                    { 68, "rock", "https://is4-ssl.mzstatic.com/image/thumb/Music112/v4/78/61/dd/7861dd44-f796-08ea-c8ff-7f8a12a86db1/15UMGIM69649.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1993, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greatest Hits" },
                    { 69, "reggae", "https://is3-ssl.mzstatic.com/image/thumb/Music113/v4/ea/20/06/ea2006f9-7512-cf9c-7b44-78116156875e/12UMGIM14712.rgb.jpg/170x170bb.png", 9.9900000000000002, new DateTime(1984, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legend – The Best of Bob Marley & The Wailers (2002 Edition)" }
                });

            migrationBuilder.InsertData(
                table: "AlbumArtists",
                columns: new[] { "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 3 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 11, 10 },
                    { 12, 8 },
                    { 13, 1 },
                    { 14, 10 },
                    { 15, 11 },
                    { 16, 1 },
                    { 17, 11 },
                    { 18, 12 },
                    { 19, 13 },
                    { 20, 14 },
                    { 21, 15 },
                    { 22, 7 },
                    { 23, 17 },
                    { 24, 3 },
                    { 25, 18 },
                    { 26, 19 },
                    { 27, 20 },
                    { 28, 8 },
                    { 29, 1 },
                    { 30, 21 },
                    { 31, 3 },
                    { 32, 22 },
                    { 33, 1 },
                    { 34, 23 },
                    { 35, 24 },
                    { 36, 25 },
                    { 37, 26 },
                    { 38, 27 },
                    { 39, 28 },
                    { 40, 19 },
                    { 41, 1 },
                    { 42, 29 }
                });

            migrationBuilder.InsertData(
                table: "AlbumArtists",
                columns: new[] { "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { 43, 30 },
                    { 44, 31 },
                    { 45, 32 },
                    { 46, 33 },
                    { 47, 34 },
                    { 48, 35 },
                    { 49, 7 },
                    { 50, 36 },
                    { 51, 37 },
                    { 52, 38 },
                    { 53, 39 },
                    { 54, 40 },
                    { 55, 41 },
                    { 56, 37 },
                    { 57, 42 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 43 },
                    { 63, 44 },
                    { 64, 1 },
                    { 65, 49 },
                    { 66, 50 },
                    { 67, 51 },
                    { 68, 52 },
                    { 69, 53 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtists_ArtistId",
                table: "AlbumArtists",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumArtists");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
