using Microsoft.EntityFrameworkCore;
public class ArtArchiveDbContext : DbContext
{
    public ArtArchiveDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Artwork> Artworks => Set<Artwork>();
}