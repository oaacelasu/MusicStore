using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Please enter the full name.")]
        [MaxLength(200)]
        [Remote("CheckArtist", "Validation", "Admin", AdditionalFields = "FullName, Operation")] 
        public string FullName { get; set; }

        public ICollection<AlbumArtist> AlbumArtists { get; set; }
    }
}
