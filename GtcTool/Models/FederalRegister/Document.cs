using System.Text;

namespace Gtc.Models.FederalRegister
{
    public class Document
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Abstract { get; set; }
        public string DocumentNumber { get; set; }
        public string HtmlUrl { get; set; }
        public string PdfUrl { get; set; }
        public string PublicInspectionPdfUrl { get; set; }
        public string PublicationDate { get; set; }
        public List<Agency> Agencies { get; set; }
        public string Excerpts { get; set; }

        public Document(string title, string type, string @abstract, string documentNumber, string htmlUrl, string pdfUrl, string publicInspectionPdfUrl, string publicationDate, string excerpts)
        {
            Title = title;
            Type = type;
            Abstract = @abstract;
            DocumentNumber = documentNumber;
            HtmlUrl = htmlUrl;
            PdfUrl = pdfUrl;
            PublicInspectionPdfUrl = publicInspectionPdfUrl;
            PublicationDate = publicationDate;
            Agencies = new List<Agency>();
            Excerpts = excerpts;
        }

        public override string ToString()
        {
            StringBuilder outputProperties = new StringBuilder();

            outputProperties.AppendLine("##Document");
            outputProperties.AppendLine($"{nameof(Title)}: {Title}");
            outputProperties.AppendLine($"{nameof(Type)}: {Type}");
            outputProperties.AppendLine($"{nameof(Abstract)}: {Abstract}");
            outputProperties.AppendLine($"{nameof(DocumentNumber)}: {DocumentNumber}");
            outputProperties.AppendLine($"{nameof(HtmlUrl)}: {HtmlUrl}");
            outputProperties.AppendLine($"{nameof(PdfUrl)}: {PdfUrl}");
            outputProperties.AppendLine($"{nameof(PublicInspectionPdfUrl)}: {PublicInspectionPdfUrl}");
            outputProperties.AppendLine($"{nameof(PublicationDate)}: {PublicationDate}");
            outputProperties.AppendLine($"{nameof(Agencies)}:\n{ListExtensions.ListToString(Agencies)}");
            outputProperties.Append($"{nameof(Excerpts)}: {Excerpts}");

            return outputProperties.ToString();
        }

    }
}
