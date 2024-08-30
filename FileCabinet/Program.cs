using System;
using FileCabinetLib.Searchers;

namespace FileCabinetConsole
{
    internal class Program
    {
        private static readonly string PathToSearchForDocumentCards = @$"{AppDomain.CurrentDomain.BaseDirectory}..\..\..\..\FileCabinetLib\DocumentCardExamples";

        static void Main()
        {
            int[] searchFilter = [ 2,4,6 ];

            var documentCardProber = new FileSystemProber(PathToSearchForDocumentCards);
            var documentCardGetter = new DocumentCardGetter(documentCardProber);

            var documentCards = documentCardGetter.GetByIds(searchFilter);

            foreach ( var documentCard in documentCards )
            {
                Console.WriteLine($"{documentCard}\n");
            }
        }
    }
}
