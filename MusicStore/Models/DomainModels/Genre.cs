using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Models
{
    public class Genre
    {
        [MaxLength(16)]
        [Required(ErrorMessage = "Please enter a genre id.")]
        [Remote("CheckGenre", "Validation", "Admin")] // include 'Admin' area name
        public string GenreId { get; set; }
        
        [StringLength(25)]
        [Required(ErrorMessage = "Please enter a genre name.")]
        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}