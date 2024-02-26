using Core.Models;

namespace Persistence.Seeding
{
    public static class RestaurantImageReader
    {
        const string file = @"Persistence\Seeding\images";

        public static RestaurantPicture[] Read(Restaurant[] restaurants)
        {
            List<RestaurantPicture> pictures = new();

            string path = CsvReader.GetFullPathTo(file);
            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(files[i]);
                string[] fileNameParts = fileName.Split('_');
                string restaurantName = fileNameParts[0];
                int index = int.Parse(fileNameParts[1]);

                if (restaurantName == "GenericRestaurant")
                {
                    continue;
                }

                int restaurantId = restaurants
                    .Where(x => x.Name == restaurantName)
                    .Select(x => x.Id)
                    .Single();

                byte[] image = File.ReadAllBytes(files[i]);

                pictures.Add(new RestaurantPicture()
                {
                    Id = i + 1,
                    Index = index,
                    RestaurantId = restaurantId,
                    Picture = image
                });
            }

            return pictures.ToArray();
        }
    }
}
