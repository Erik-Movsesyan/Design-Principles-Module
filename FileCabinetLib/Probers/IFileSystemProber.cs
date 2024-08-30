using System.Collections.Generic;

namespace FileCabinetLib.Searchers
{
    public interface IFileProber
    {
        IEnumerable<string> Probe();
    }
}
