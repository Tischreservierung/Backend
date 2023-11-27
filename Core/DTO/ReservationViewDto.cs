using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class ReservationViewDto
    {
        public int Id { get; set; }

        public string RestaurantName { get; set; } = string.Empty;

        public byte[]? Picture { get; set; }


    }
}
