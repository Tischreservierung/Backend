using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class RestaurantTableDto
    {
        public int Id { get; set; }

        public int SeatPlaces { get; set; }

        public DateTime? LastReservation {  get; set; }

        public DateTime? ClosedAt { get; set; }
    }
}
