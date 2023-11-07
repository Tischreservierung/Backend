using Core.Models;

namespace Persistence.Seeding
{
    public static class ZipCodeCsvReader
    {
        const string file = @"Persistence\Seeding\csv\ZipCodes.txt";

        public static ZipCode[] Read()
        {
            string[] lines = CsvReader.Read(file);

            ZipCode[] zipCodes = new ZipCode[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] cols = lines[i].Split('\t', StringSplitOptions.RemoveEmptyEntries);

                string district = cols[4].Split(' ')[1];

                zipCodes[i] = new ZipCode()
                {
                    Id = i + 1,
                    ZipCodeNr = cols[1],
                    Location = cols[2],
                    District = district
                };
            }

            return zipCodes;
        }
    }
}
