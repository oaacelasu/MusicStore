using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
            : base(options)
        { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumArtist> AlbumArtists { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // AlbumArtist: set primary key 
            modelBuilder.Entity<AlbumArtist>().HasKey(ba => new { ba.AlbumId, ba.ArtistId });

            // AlbumArtist: set foreign keys 
            modelBuilder.Entity<AlbumArtist>().HasOne(ba => ba.Album)
                .WithMany(b => b.AlbumArtists)
                .HasForeignKey(ba => ba.AlbumId);
            modelBuilder.Entity<AlbumArtist>().HasOne(ba => ba.Artist)
                .WithMany(a => a.AlbumArtists)
                .HasForeignKey(ba => ba.ArtistId);

            // Album: remove cascading delete with Genre
            modelBuilder.Entity<Album>().HasOne(b => b.Genre)
                .WithMany(g => g.Albums)
                .OnDelete(DeleteBehavior.Restrict);

            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedGenres());
            modelBuilder.ApplyConfiguration(new SeedAlbums());
            modelBuilder.ApplyConfiguration(new SeedArtists());
            modelBuilder.ApplyConfiguration(new SeedAlbumArtists());
        }
    }
}
