using System;
using System.Collections.Generic;
using System.IO;

namespace FileCabinetLib.Searchers
{
    public class FileSystemProber : IFileProber
    {
        private string _searchFolderPath;

        private const string SearchPattern = "*_#*.json";

        public string SearchFolderPath { get => _searchFolderPath; set { ValidateSearchFolderPath(value); _searchFolderPath = value; } }

        public FileSystemProber(string searchFolderPath)
        {
            ValidateSearchFolderPath(searchFolderPath);
            SearchFolderPath = searchFolderPath;
        }

        public IEnumerable<string> Probe()
        {
            var files = Directory.EnumerateFiles(_searchFolderPath, SearchPattern, SearchOption.TopDirectoryOnly);
            return files;
        }

        private static void ValidateSearchFolderPath(string path)
        {
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
                throw new ArgumentException("The path to the document cards is incorrect");
        }
    }
}
