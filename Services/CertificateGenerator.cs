using Microsoft.AspNetCore.Mvc.RazorPages;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class CertificateGenerator
{
  private readonly ICertificateTemplate _template;

  public CertificateGenerator(ICertificateTemplate template)
  {
    _template = template;
  }
public byte[] GenerateCertificate(Artwork artwork)
  {
    return Document.Create(container =>
    {
      //QuestPdf doc definition
      container.Page(page =>
      {
        page.Size(PageSizes.A4);
        page.Margin(50);
        page.DefaultTextStyle(x => x.FontSize(18));

        page.Content().Column(col =>
        {
          col.Item().Text("Certificate of Authenticity")
            .FontSize(18).Bold().AlignCenter();

          col.Item().PaddingVertical(20);
          col.Item().Text($"Title; {artwork.Title}");
          col.Item().Text($"Artist: {artwork.Artist}");
          col.Item().Text($"Year: {artwork.Year}");
          col.Item().Text($"Medium: {artwork.Medium}");
          col.Item().PaddingVertical(20);
          
          col.Item().Text($"Issued: {DateTime.UtcNow:d}");
          col.Item().Text("Verified by Art Archive System")
            .Italic();
        });
      });
    }).GeneratePdf();
  }
}