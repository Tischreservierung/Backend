﻿namespace Persistence.Seeding
{
    public static class CsvReader
    {
        public static readonly string SolutionPath = TryGetSolutionDirectoryInfo().FullName;

        public static DirectoryInfo TryGetSolutionDirectoryInfo()
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any() && directory.FullName != "src")
            {
                directory = directory.Parent;
            }
            return directory!;
        }

        public static string GetFullPathTo(string file)
        {
            file = file.Trim().Replace('\\', Path.DirectorySeparatorChar);
            return Path.Combine(SolutionPath, file);
        }

        public static string[] Read(string file)
        {
            string path = GetFullPathTo(file);
            return File.ReadAllLines(path);
        }
    }
}