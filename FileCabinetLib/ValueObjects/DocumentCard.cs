using System;
using System.Text.Json.Serialization;

namespace FileCabinetLib.ValueObjects
{
    public abstract class DocumentCard
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("authors")]
        public string[] Authors { get; set; }

        [JsonPropertyName("datePublished")]
        public DateOnly DatePublished { get; set; }

        public override string ToString()
        {
            var authors = string.Join(',', Authors);
            return $"Title: {Title}\nAuthors: {authors}\nDatePublished: {DatePublished}";
        }
    }
}
