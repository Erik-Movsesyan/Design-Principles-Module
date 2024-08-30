using System;
using System.Text.Json.Serialization;

namespace FileCabinetLib.ValueObjects
{
    public class Patent : DocumentCard
    {
        [JsonPropertyName("expirationDate")]
        public DateOnly ExpirationDate { get; set; }

        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        public override string ToString()
        {
            return $"<{nameof(Patent)}>\n{base.ToString()}\nexpirationDate: {ExpirationDate}\nuniqueId: {UniqueId}";
        }
    }
}
