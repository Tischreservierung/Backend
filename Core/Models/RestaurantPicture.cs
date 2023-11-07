using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class RestaurantPicture : EntityObject
    {
        public byte[]? Picture { get; set; }
        public int Index { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        [JsonIgnore]
        public Restaurant? Restaurant { get; set; }
    }
}
