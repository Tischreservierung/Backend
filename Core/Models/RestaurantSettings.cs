namespace Core.Models
{
    public class RestaurantSettings : EntityObject
    {
        public List<int> Durations { get; set; } = new();
        public int ReservationTimeOffset { get; set; }
    }
}
