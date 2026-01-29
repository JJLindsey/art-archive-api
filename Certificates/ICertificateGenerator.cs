using ArtArchive.Models;
public interface ICertificateGenerator
{
    byte[] GenerateCertificate(Artwork artwork);
}