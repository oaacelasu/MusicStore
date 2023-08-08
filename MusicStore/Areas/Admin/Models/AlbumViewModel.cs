using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class AlbumViewModel : IValidatableObject
    {
        public Album Album { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public int[] SelectedArtists { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext ctx) {
            if (SelectedArtists == null)
            {
                yield return new ValidationResult(
                  "Please select at least one artist.",
                  new[] { nameof(SelectedArtists) });
            }
        }

    }
}
