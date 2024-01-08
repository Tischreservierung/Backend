namespace Core.Dto
{
    public class ReservationManualDto
    {
        public DateTime Day { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPersons { get; set; }
        public int RestaurantId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
