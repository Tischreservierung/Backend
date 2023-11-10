namespace Persistence.Seeding
{
    public static class CsvReader
    {
        public static readonly string SolutionPath = GetSolutionDirectory();

        public static string GetSolutionDirectory()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo? solutionDir = Directory.GetParent(currentDir);
            
            if (solutionDir == null)
            {
                throw new DirectoryNotFoundException("Solution directory not found!");
            }

            return solutionDir.FullName;
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
