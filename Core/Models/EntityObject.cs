using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class EntityObject
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
