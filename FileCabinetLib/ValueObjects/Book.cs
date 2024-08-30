using System.Text.Json.Serialization;

namespace FileCabinetLib.ValueObjects
{
    public class Book : AbstractBook
    {
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        public override string ToString()
        {
            return $"<{nameof(Book)}>\n{base.ToString()}\npublisher: {Publisher}";
        }
    }
}
