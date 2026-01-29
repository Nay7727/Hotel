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

        public Reservation GetReservation(int id)
        {
            return repository.Get(id);
        }

        
        public void UpdateReservation(Reservation reservation)
        {
            if (reservation == null)
                throw new Exception("Reservation is null");

            if (reservation.StartDate >= reservation.EndDate)
                throw new Exception("Invalid dates");

            repository.Update(reservation);
        }

        
        public void DeleteReservation(int id)
        {
            repository.Delete(id);
        }

    }
}
