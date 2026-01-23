public class ArtArchiveCertificateTemplate : ICertificateTemplate
{
    public static string Header => "Certificate of Authenticity";

    public static string Body => @"
    This document certifies that the artwork described below is registered in the
Art Archive & Provenance Tracker as of the date issued.

This certificate reflects the archival record maintained by the issuing authority
and does not constitute scholarly attribution, market valuation, or legal authentication.
";
    public string Footer => @"Issued by Art Archive System";
}