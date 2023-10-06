using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
