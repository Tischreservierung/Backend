namespace Core.Dto
{
    public class ReservationViewDto
    {
        public int Id { get; set; }

        public string RestaurantName { get; set; } = string.Empty;

        public byte[]? Picture { get; set; }


    }
}
