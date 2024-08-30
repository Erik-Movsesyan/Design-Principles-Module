using System.Text.Json.Serialization;

namespace FileCabinetLib.ValueObjects
{
    public class LocalizedBook : AbstractBook
    {
        [JsonPropertyName("originalPublisher")]
        public string OriginalPublisher { get; set; }

        [JsonPropertyName("localPublisher")]
        public string LocalPublisher { get; set; }

        [JsonPropertyName("countryOfLocalization")]
        public string LocalizationCountry { get; set; }

        public override string ToString()
        {
            return $"<{nameof(LocalizedBook)}>\n{base.ToString()}\noriginalPublisher: {OriginalPublisher}" +
                $"\nlocalPublisher: {LocalPublisher}\ncountryOfLocalization: {LocalizationCountry}";
        }
    }
}
