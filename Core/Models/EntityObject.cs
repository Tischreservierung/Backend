using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class EntityObject
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        [JsonIgnore]
        public byte[]? RowVersion { get; set; }
    }
}
