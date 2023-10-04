using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
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
