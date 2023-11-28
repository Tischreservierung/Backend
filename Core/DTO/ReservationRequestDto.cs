namespace Core.Dto
{
    public class ReservationRequestDto
    {
        public  DateTime Day { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPersons { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
    }
}
