using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/artworks")]
public class ArtworksController : ControllerBase
{
  private readonly ArtArchiveDbContext _context;
  public ArtworksController(ArtArchiveDbContext context)
  {
    _context = context;
  }
  [HttpGet]
  public async Task<IEnumerable<Artwork>> GetArtworks()
    => await _context.Artworks.ToListAsync();
  
  [HttpPost]
  public async Task<IActionResult> CreateArtwork(Artwork artwork)
  {
    _context.Artworks.Add(artwork);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetArtworks), new { id = artwork.Id }, artwork);
  }
}