namespace WebApi.QueryParams
{
    public class ReservationOptionQueryParams
    {
        public DateTime From { get; set; } = DateTime.Today;
        public DateTime To { get; set; } = DateTime.Today.Add(new TimeSpan(23, 59, 00));
        public DateTime Day { get; set; } = DateTime.Today;
        public int SeatPlaces { get; set; } = 1;
    }
}
