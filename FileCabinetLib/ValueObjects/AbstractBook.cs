using System.Text.Json.Serialization;

namespace FileCabinetLib.ValueObjects
{
    public abstract class AbstractBook : DocumentCard
    {
        public string ISBN { get; set; }

        [JsonPropertyName("numberOfPages")]
        public int PageNumber { get; set; }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\nnumberOfPages: {PageNumber}";
        }
    }
}
