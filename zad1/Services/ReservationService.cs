using HotelSystem.Models;
using HotelSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services
{
    public class ReservationService
    {
        private readonly ReservationRepository repository = new();

        public void CreateReservation(Reservation reservation)
        {
            if (reservation.StartDate >= reservation.EndDate)
                throw new Exception("Invalid dates");

            repository.Add(reservation);
        }

        public List<Reservation> GetReservations()
        {
            return repository.GetAll();
        }
    }
}
