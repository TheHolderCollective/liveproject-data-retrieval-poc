using System.Text;

namespace Gtc.Models.FederalRegister
{
    public class Agency
    {
        public string RawName { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string JsonUrl { get; set; }
        public int? ParentId { get; set; }
        public string Slug { get; set; }

        public Agency(string rawName, string name, int id, string url, string jsonUrl, int? parentId, string slug)
        {
            RawName = rawName;
            Name = name;
            Id = id;
            Url = url;
            JsonUrl = jsonUrl;
            ParentId = parentId;
            Slug = slug;
        }

        public override string ToString()
        {
            StringBuilder outputProperties = new StringBuilder();

            outputProperties.AppendLine("###Agency");
            outputProperties.AppendLine($"{nameof(RawName)}: {RawName}");
            outputProperties.AppendLine($"{nameof(Name)}: {Name}");
            outputProperties.AppendLine($"{nameof(Id)}: {Id}");
            outputProperties.AppendLine($"{nameof(Url)}: {Url}");
            outputProperties.AppendLine($"{nameof(JsonUrl)}: {JsonUrl}");
            outputProperties.AppendLine($"{nameof(ParentId)}: {ParentId}");
            outputProperties.Append($"{nameof(Slug)}: {Slug}");

            return outputProperties.ToString();
        }
    }
}
