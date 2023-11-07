using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Seeding
{
    public static class CsvReader
    {
        public static readonly string SolutionPath = TryGetSolutionDirectoryInfo().FullName;

        public static DirectoryInfo TryGetSolutionDirectoryInfo()
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        public static string[] Read(string file)
        {
            string path = Path.Combine(SolutionPath, file);
            return File.ReadAllLines(path);
        }
    }
}
