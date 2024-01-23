using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class RestaurantUser : EntityObject
    {
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
