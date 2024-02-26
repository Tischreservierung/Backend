using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class Category : EntityObject
    {
        [Required]
        [MinLength(3)]
        [MaxLength(64)]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    }
}
