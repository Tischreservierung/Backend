using Core.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Reservation : EntityObject
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReservationDay { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey(nameof(RestaurantTable))]
        public int? RestaurantTableId { get; set; }
        public RestaurantTable? RestaurantTable { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public int? RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
