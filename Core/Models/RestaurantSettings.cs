using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class RestaurantSettings : EntityObject, IValidatableObject
    {
        public List<int> Durations { get; set; } = new();
        public int ReservationTimeOffset { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ReservationTimeOffset <= 10)
            {
                yield return new ValidationResult("Reservation time offset must be greater than 10 minutes!");
            }

            if (60 % ReservationTimeOffset != 0)
            {
                yield return new ValidationResult("Reservation time offset must be a factor of 60!");
            }

            foreach (var duration in Durations)
            {
                if (duration % 15 != 0)
                {
                    yield return new ValidationResult("Reservation duration must be a multiple of 15!");
                }
            }
        }
    }
}
