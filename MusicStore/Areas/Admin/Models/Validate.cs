using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MusicStore.Models
{
    public class Validate
    {
        private const string GenreKey = "validGenre";
        private const string ArtistKey = "validArtist";

        private ITempDataDictionary tempData { get; set; }
        public Validate(ITempDataDictionary temp) => tempData = temp;

        public bool IsValid { get; private set; }
        public string ErrorMessage { get; private set; }

        public void CheckGenre(string genreId, IRepository<Genre> data)
        {
            Genre entity = data.Get(genreId);
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" : 
                $"Genre id {genreId} is already in the database.";
        }
        public void MarkGenreChecked() => tempData[GenreKey] = true;
        public void ClearGenre() => tempData.Remove(GenreKey);
        public bool IsGenreChecked => tempData.Keys.Contains(GenreKey);

        public void CheckArtist(string fullName, string operation, IRepository<Artist> data)
        {
            Artist entity = null; 
            if (Operation.IsAdd(operation)) {
                entity = data.Get(new QueryOptions<Artist> {
                    Where = a => a.FullName == fullName});
            }
            IsValid = (entity == null) ? true : false;
            ErrorMessage = (IsValid) ? "" : 
                $"Artist {entity.FullName} is already in the database.";
        }
        public void MarkArtistChecked() => tempData[ArtistKey] = true;
        public void ClearArtist() => tempData.Remove(ArtistKey);
        public bool IsArtistChecked => tempData.Keys.Contains(ArtistKey);

    }
}
