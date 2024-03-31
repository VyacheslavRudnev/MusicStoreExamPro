using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DataContext : DbContext
{
    public DbSet<ArtistData> Artist { get; set; }
    public DbSet<AlbumData> Album { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var artist = modelBuilder.Entity<ArtistData>();
        artist.HasIndex(x => x.Name).IsUnique();
        artist.Property(x => x.Name).IsRequired();

        artist.Property(x => x.Name).HasMaxLength(100);

        artist.HasMany(artist => artist.Album).WithOne();

        var album = modelBuilder.Entity<AlbumData>();
        album.HasIndex(x => x.Title).IsUnique();
        album.Property(x => x.Title).IsRequired();
        album.Property(x => x.Title).HasMaxLength(64);
        album.Property(x => x.Publisher).IsRequired();
        album.Property(x => x.Publisher).HasMaxLength(64);
        album.Property(x => x.Tracks).IsRequired();
        album.Property(x => x.Genre).IsRequired(false);
        album.Property(x => x.Genre).HasMaxLength(32);
        album.Property(x => x.Year).IsRequired();
        album.Property(x => x.CostPrice).IsRequired();
        album.Property(x => x.SellPrice).IsRequired();
        album.HasOne(album => album.Artist).WithMany();
    }

}
