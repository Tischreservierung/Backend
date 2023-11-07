using Core.Models;

namespace Persistence.Seeding
{
    public static class CategoryCsvReader
    {
        const string file = @"..\Persistence\Seeding\csv\Categories.csv";

        public static Category[] Read()
        {
            string[] lines = File.ReadAllLines(file);

            Category[] cateogries = new Category[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                cateogries[i] = new Category()
                {
                    Id = i + 1,
                    Name = lines[i]
                };
            }

            return cateogries;
        }
    }
}
