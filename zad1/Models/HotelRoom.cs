using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public decimal RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }

        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
