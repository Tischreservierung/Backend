using Core.Models;
using System.Globalization;
using System.Reflection.Emit;

namespace Persistence.Seeding
{
    public static class RestaurantTestDataReader
    {
        const string file = @"Persistence\Seeding\csv\RestaurantTestData.csv";

        public static Restaurant[] Read(ZipCode[] zipCodes)
        {
            string[] lines = CsvReader.Read(file);

            Restaurant[] restaurants = new Restaurant[lines.Length - 1];

            for (int i = 1; i < lines.Length; i++)
            {
                string[] cols = lines[i].Split(';');

                restaurants[i - 1] = new Restaurant()
                {
                    Id = i,
                    Name = cols[0],
                    Description = cols[1],
                    ZipCodeId = zipCodes.Where(z => z.ZipCodeNr == cols[2]).Select(z => z.Id).First(),
                    Address = cols[3],
                    StreetNr = cols[4]
                };
            }

            return restaurants;
        }
    }
}
