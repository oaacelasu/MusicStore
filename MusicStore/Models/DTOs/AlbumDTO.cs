using System;
using System.Collections.Generic;

namespace MusicStore.Models
{
    public class AlbumDTO
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        
        public string Image { get; set; }
        
        public string ReleaseDate { get; set; }

        public Dictionary<int, string> Artists { get; set; }

        public void Load(Album album)
        {
            AlbumId = album.AlbumId;
            Title = album.Title;
            Price = album.Price;
            Artists = new Dictionary<int, string>();
            Image = album.Image;
            ReleaseDate = album.ReleaseDate.ToString("yyyy-MM-dd");
            foreach (AlbumArtist ba in album.AlbumArtists) {
                Artists.Add(ba.Artist.ArtistId, ba.Artist.FullName);
            }
        }
    }

}
