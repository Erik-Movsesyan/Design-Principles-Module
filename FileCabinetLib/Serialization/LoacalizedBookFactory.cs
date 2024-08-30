using System.IO;
using FileCabinetLib.ValueObjects;
using System.Text.Json;
using FileCabinetLib.Exceptions;

namespace FileCabinetLib.Serialization
{
    public class LocalizedBookFactory : IDocumentCardFactory
    {
        public DocumentCard Create(string filePath)
        {
            var jsonContent = File.ReadAllText(filePath);
            LocalizedBook localizedBook;

            try
            {
                localizedBook = JsonSerializer.Deserialize<LocalizedBook>(jsonContent);
            }
            catch
            {
                throw new DocumentCardException($"Could not correctly Deserialize To {typeof(LocalizedBook)} the contents of the file at path {filePath}");
            }

            return localizedBook;
        }
    }
}
