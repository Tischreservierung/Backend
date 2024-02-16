using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class Restaurant : EntityObject
    {
        [Required]
        [MinLength(3)]
        [MaxLength(64)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MinLength(3)]
        [MaxLength(64)]
        public string Address { get; set; } = string.Empty;
        [Required]
        [MinLength(1)]
        [MaxLength(16)]
        public string StreetNr { get; set; } = string.Empty;

        [ForeignKey(nameof(ZipCode))]
        public int ZipCodeId { get; set; }
        [JsonIgnore]
        public ZipCode? ZipCode { get; set; }

        [JsonIgnore]
        public List<RestaurantTable> Tables { get; set; } = new List<RestaurantTable>();
        [JsonIgnore]
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
