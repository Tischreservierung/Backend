using Core.Models;
using System.Globalization;

namespace Persistence.Seeding
{
    public static class OpeningTimeTestDataReader
    {
        const string file = @"..\Persistence\Seeding\csv\OpeningTimeTestData.csv";

        public static RestaurantOpeningTime[] Read()
        {
            string[] lines = File.ReadAllLines(file);

            List<RestaurantOpeningTime> openingTimes = new();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] days = lines[i].Split(';');


                for (int j = 0; j < days.Length; j++)
                {
                    string[] times = days[j].Split(',');

                    if (times[0] == "geschlossen")
                    {
                        continue;
                    }

                    for (int k = 0; k < times.Length; k++)
                    {
                        string[] hours = times[k].Split('-');

                        int restaurantId = i + 1;
                        int id = restaurantId * 100 + j * 10 + k;

                        openingTimes.Add(new RestaurantOpeningTime()
                        {
                            Id = id,
                            OpeningTime = TimeSpan.ParseExact(hours[0], "c", CultureInfo.InvariantCulture),
                            ClosingTime = TimeSpan.ParseExact(hours[1], "c", CultureInfo.InvariantCulture),
                            Day = (DayOfWeek)j,
                            RestaurantId = restaurantId
                        });
                    }
                }
            }

            return openingTimes.ToArray();
        }
    }
}
