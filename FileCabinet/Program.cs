using System;
using FileCabinetLib.Searchers;

namespace FileCabinetConsole
{
    internal class Program
    {
        static void Main()
        {
            const string pathToSearchForDocumentCards = @"C:\Users\Erik_Movsesyan\OneDrive - EPAM\.NET Training\Homework\Design Principles\FileCabinet\FileCabinetLib\DocumentCardExamples";
            int[] searchFilter = [ 2,4,6 ];

            var documentCardProber = new FileSystemProber(pathToSearchForDocumentCards);
            var documentCardGetter = new DocumentCardGetter(documentCardProber);

            var documentCards = documentCardGetter.GetByIds(searchFilter);

            foreach ( var documentCard in documentCards )
            {
                Console.WriteLine($"{documentCard}\n");
            }
        }
    }
}
