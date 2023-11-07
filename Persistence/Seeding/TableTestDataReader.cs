using Core.Models;

namespace Persistence.Seeding
{
    public static class TableTestDataReader
    {
        const string file = @"Persistence\Seeding\csv\TablesTestData.csv";

        public static RestaurantTable[] Read()
        {
            string[] lines = CsvReader.Read(file);

            List<RestaurantTable> restaurantTables = new();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] cols = lines[i].Split(';');

                for (int j = 0; j < cols.Length; j++)
                {
                    int restaurantId = i + 1;
                    int id = restaurantId * 100 + j;

                    restaurantTables.Add(new RestaurantTable()
                    {
                        Id = id,
                        RestaurantId = restaurantId,
                        SeatPlaces = int.Parse(cols[j])
                    });
                }
            }

            return restaurantTables.ToArray();
        }
    }
}
