using System.Collections.Generic;
using System.Linq;
using FileCabinetLib.Helpers;
using FileCabinetLib.Serialization;
using FileCabinetLib.ValueObjects;

namespace FileCabinetLib.Searchers
{
    public class DocumentCardGetter(IFileProber fileProber) : IDocumentCardGetter
    {
        private readonly Dictionary<string, IDocumentCardFactory> _documentCardFactories = new()
        {
            { "book", new BookFactory() },
            { "patent", new PatentFactory() },
            { "localizedbook", new LocalizedBookFactory() }
        };

        public IEnumerable<DocumentCard> GetByIds(IEnumerable<int> ids)
        {
            var documentCardsList = new List<DocumentCard>();
            var files = fileProber.Probe();

            foreach (var filePath in files.Where(fileName => ids.Any(id => fileName.Contains(id.ToString())))) 
            {
                var documentCardNamePrefix = DocumentCardPrefixExtractor.GetDocumentCardNamePrefix(filePath);

                var deserializedDocumentCard = _documentCardFactories[documentCardNamePrefix].Create(filePath);
                documentCardsList.Add(deserializedDocumentCard);
            }

            return documentCardsList;
        }
    }
}
