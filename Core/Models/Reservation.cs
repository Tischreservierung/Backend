using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Reservation : EntityObject, IValidatableObject
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReservationDay { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public AuthUser? Customer { get; set; }

        [ForeignKey(nameof(RestaurantTable))]
        public int RestaurantTableId { get; set; }
        public RestaurantTable? RestaurantTable { get; set; }

        [Range(0, int.MaxValue)]
        public int Persons { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            TimeSpan difference = EndTime - StartTime;

            if (difference.Ticks < 0)
            {
                yield return new ValidationResult("Start and End dates cannot overlap!");
            }
        }
    }
}
