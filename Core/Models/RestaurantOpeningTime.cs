using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class RestaurantOpeningTime : EntityObject, IValidatableObject
    {
        [Required]
        public DayOfWeek Day { get; set; }
        [Required]
        public TimeSpan OpeningTime { get; set; }
        [Required]
        public TimeSpan ClosingTime { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        [JsonIgnore]
        public Restaurant? Restaurant { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            TimeSpan difference = ClosingTime - OpeningTime;

            if (difference.Ticks < 0)
            {
                yield return new ValidationResult("Start and End dates cannot overlap!");
            }

            if (difference.TotalMinutes < 60)
            {
                yield return new ValidationResult("Opening time cannot be smaller than 60 minutes!");
            }
        }
    }
}
