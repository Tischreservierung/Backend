using Core.Models;

namespace Core.Dto
{
    public class RestaurantPostDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ZipCode? ZipCode { get; set; }
        public string Address { get; set; } = string.Empty;
        public string StreetNr { get; set; } = string.Empty;

        public Category[] Categories { get; set; } = Array.Empty<Category>();
        public OpeningTimeDto[] Openings { get; set; } = Array.Empty<OpeningTimeDto>();
        public int[] Tables { get; set; } = Array.Empty<int>();

        public string[] Pictures { get; set; } = Array.Empty<string>();
    }
}
