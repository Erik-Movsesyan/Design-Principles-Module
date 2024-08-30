using FileCabinetLib.ValueObjects;
using System.Collections.Generic;

namespace FileCabinetLib.Searchers
{
    public interface IDocumentCardGetter
    {
        IEnumerable<DocumentCard> GetByIds(IEnumerable<int> ids);
    }
}
