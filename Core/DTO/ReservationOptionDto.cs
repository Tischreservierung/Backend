using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class ReservationOptionDto
    {
        public DateTime Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Duration { get; set; }
        public int RestaurantTableId { get; set; }
        public int SeatPlaces { get; set; }
    }
}
