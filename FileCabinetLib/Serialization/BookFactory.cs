using FileCabinetLib.Exceptions;
using FileCabinetLib.ValueObjects;
using System.IO;
using System.Text.Json;

namespace FileCabinetLib.Serialization
{
    public class BookFactory : IDocumentCardFactory
    {
        public DocumentCard Create(string filePath)
        {
            var jsonContent = File.ReadAllText(filePath);
            Book book;

            try
            {
                book = JsonSerializer.Deserialize<Book>(jsonContent);
            }
            catch
            {
                throw new DocumentCardException($"Could not correctly Deserialize To {typeof(Book)} the contents of the file at path {filePath}");
            }

            return book;
        }
    }
}
