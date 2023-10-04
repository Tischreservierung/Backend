using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class ReservationDto
    {
        public DateTime ReservationDay { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CustomerId { get; set; }
        public int? RestaurantTableId { get; set; }
        public int? RestaurantId { get; set; }
    }
}
