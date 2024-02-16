using Core.Models;

namespace Core.Dto
{
    public class RestaurantEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ZipCode ZipCode { get; set; } = new();

        public string Address { get; set; } = string.Empty;
        public string StreetNr { get; set; } = string.Empty;

        public List<Category> Categories { get; set; } = new();
        public List<RestaurantTable> Tables { get; set; } = new();
        public List<RestaurantOpeningTime> Openings { get; set; } = new();
        public List<RestaurantPicture> Pictures { get; set; } = new();
    }
}
