namespace MusicStore.Models
{
    public class MusicStoreUnitOfWork : IMusicStoreUnitOfWork
    {
        private MusicStoreContext context { get; set; }
        public MusicStoreUnitOfWork(MusicStoreContext ctx) => context = ctx;

        private Repository<Album> albumData;
        public Repository<Album> Albums {
            get {
                if (albumData == null)
                    albumData = new Repository<Album>(context);
                return albumData;
            }
        }

        private Repository<Artist> artistData;
        public Repository<Artist> Artists {
            get {
                if (artistData == null)
                    artistData = new Repository<Artist>(context);
                return artistData;
            }
        }

        private Repository<AlbumArtist> albumartistData;
        public Repository<AlbumArtist> AlbumArtists {
            get {
                if (albumartistData == null)
                    albumartistData = new Repository<AlbumArtist>(context);
                return albumartistData;
            }
        }

        private Repository<Genre> genreData;
        public Repository<Genre> Genres
        {
            get {
                if (genreData == null)
                    genreData = new Repository<Genre>(context);
                return genreData;
            }
        }

        public void DeleteCurrentAlbumArtists(Album album)
        {
            var currentArtists = AlbumArtists.List(new QueryOptions<AlbumArtist> {
                Where = ba => ba.AlbumId == album.AlbumId
            });
            foreach (AlbumArtist ba in currentArtists) {
                AlbumArtists.Delete(ba);
            }
        }

        public void LoadNewAlbumArtists(Album album, int[] artistids)
        {
            foreach (int id in artistids) {
                AlbumArtist ba = new AlbumArtist { Album = album, ArtistId = id };
                AlbumArtists.Insert(ba);
            }
        }

        public void Save() => context.SaveChanges();
    }
}