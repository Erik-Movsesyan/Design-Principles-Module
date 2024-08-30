using System.IO;
using FileCabinetLib.ValueObjects;
using System.Text.Json;
using FileCabinetLib.Exceptions;

namespace FileCabinetLib.Serialization
{
    public class PatentFactory : IDocumentCardFactory
    {
        public DocumentCard Create(string filePath)
        {
            var jsonContent = File.ReadAllText(filePath);
            Patent patent;

            try
            {
                patent = JsonSerializer.Deserialize<Patent>(jsonContent);
            }
            catch
            {
                throw new DocumentCardException($"Could not correctly Deserialize To {typeof(Patent)} the contents of the file at path {filePath}");
            }

            return patent;
        }
    }
}
