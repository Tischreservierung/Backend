namespace Core.Dto
{
    public class ReservationDto
    {
        public DateTime Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantTableId { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public int Persons { get; set; }
        public int SeatPlaces { get; set; }
    }
}
