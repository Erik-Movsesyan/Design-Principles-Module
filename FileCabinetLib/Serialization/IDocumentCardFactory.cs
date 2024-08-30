using FileCabinetLib.ValueObjects;

namespace FileCabinetLib.Serialization
{
    internal interface IDocumentCardFactory
    {
        DocumentCard Create(string filePath);
    }
}
