using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public partial class Album
    {
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(0.0, 1000000.0, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please select a genre.")]
        public string GenreId { get; set; }

        public Genre Genre { get; set; }
        
        
        [Required(ErrorMessage = "Please enter the release date.")]
        public DateTime ReleaseDate { get; set; }
        
        public string Image { get; set; }
        
        public ICollection<AlbumArtist> AlbumArtists { get; set; }
    }
}
