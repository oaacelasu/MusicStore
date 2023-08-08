namespace MusicStore.Models
{
    public interface IMusicStoreUnitOfWork
    {
        Repository<Album> Albums { get; }
        Repository<Artist> Artists { get; }
        Repository<AlbumArtist> AlbumArtists { get; }
        Repository<Genre> Genres { get; }

        void DeleteCurrentAlbumArtists(Album album);
        void LoadNewAlbumArtists(Album album, int[] artistids);
        void Save();
    }
}
