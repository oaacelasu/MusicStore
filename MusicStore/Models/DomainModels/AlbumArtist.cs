﻿namespace MusicStore.Models
{
    public class AlbumArtist
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}
