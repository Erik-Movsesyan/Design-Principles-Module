using System.Text.RegularExpressions;

namespace FileCabinetLib.Helpers
{
    internal static partial class DocumentCardPrefixExtractor
    {
        internal static string GetDocumentCardNamePrefix(string filename)
        {
            return DocumentFilePrefixRegex().Match(filename).Value.ToLower();
        }

        [GeneratedRegex(@"(?:book|localizedbook|patent)(?=_#\d+\.json$)", RegexOptions.IgnoreCase)]
        private static partial Regex DocumentFilePrefixRegex();
    }
}
