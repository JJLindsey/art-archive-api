public class Artwork
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Medium { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public string IssuingAuthority { get; set; } = string.Empty;
}