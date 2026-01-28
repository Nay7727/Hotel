using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Repository

{
    public class ReservationRepository
    {
        public void Add(Reservation r)
        {
            using var db = new HotelDbContext();
            db.Reservations.Add(r);
            db.SaveChanges();
        }

        public Reservation Get(int id)
        {
            using var db = new HotelDbContext();
            return db.Reservations.Find(id);
        }

        public List<Reservation> GetAll()
        {
            using var db = new HotelDbContext();
            return db.Reservations.ToList();
        }

        public void Update(Reservation r)
        {
            using var db = new HotelDbContext();
            db.Reservations.Update(r);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HotelDbContext();
            var res = db.Reservations.Find(id);
            if (res != null)
            {
                db.Reservations.Remove(res);
                db.SaveChanges();
            }
        }
    }
}
