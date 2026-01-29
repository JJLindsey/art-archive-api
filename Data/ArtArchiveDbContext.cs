using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using ArtArchive.Models;
public class ArtArchiveDbContext : DbContext
{
    public ArtArchiveDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Artwork> Artworks => Set<Artwork>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artwork>().HasData(
            new Artwork
            {
                Id = 1,
                Title = "Starry Night",
                Artist = "Vincent van Gogh",
                Year = 1889,
                Medium = "oil on canvas",
                Dimensions = "29 x 36 1/4\"",
                Collection = "MOMA, New York",
                CreatedAt = new DateTime(2026, 1, 20),
                IssuingAuthority = "Art Archive & Provenance Ltd."
            },
            new Artwork
            {
                Id = 2,
                Title = "This Kiss",
                Artist = "Gustav Klimt",
                Year = 1908,
                Medium = "oil and gold leaf on canvas",
                Dimensions = "180 x 180 cm",
                Collection = "Belvedere Museum, Vienna",
                CreatedAt = new DateTime(2026, 1, 20),
                IssuingAuthority = "Art Archive & Provenance Ltd."
            }
        );
    }
}
