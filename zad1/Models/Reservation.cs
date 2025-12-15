using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int GuestId { get; set; }
        public Guest Guest { get; set; }

        public int RoomId { get; set; }
        public HotelRoom Room { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Payment> Payments { get; set; }
    }
}
