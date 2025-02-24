using System.Text;

namespace Gtc.Models.FederalRegister
{
    public class Response
    {
        public int Count { get; set; }
        public int TotalPages { get; set; }
        public string Description { get; set; }
        public string NextPageUrl { get; set; }
        public List<Document> Results { get; set; }

        public Response(int count, string description, int totalpages, string nextpageurl)
        {
            Count = count;
            TotalPages = totalpages;
            Description = description;
            NextPageUrl = nextpageurl;
            Results = new List<Document>();
        }

        public override string ToString()
        {
            StringBuilder outputProperties = new StringBuilder();

            outputProperties.AppendLine("#Response");
            outputProperties.AppendLine($"{nameof(Count)}: {Count}");
            outputProperties.AppendLine($"{nameof(Description)}: {Description}");
            outputProperties.AppendLine($"{nameof(TotalPages)}: {TotalPages}");
            outputProperties.AppendLine($"{nameof(NextPageUrl)}: {NextPageUrl}");
            outputProperties.Append($"{nameof(Results)}:\n{ListExtensions.ListToString(Results)}");

            return outputProperties.ToString();
        }
    }
}
