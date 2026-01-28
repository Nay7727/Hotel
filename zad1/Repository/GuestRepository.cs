using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HotelSystem.Repository
{
    public class GuestRepository
    {
        public void Add(Guest guest)
        {
            using var db = new HotelDbContext();
            db.Guests.Add(guest);
            db.SaveChanges();
        }

        public Guest Get(int id)
        {
            using var db = new HotelDbContext();
            return db.Guests.Find(id);
        }

        public List<Guest> GetAll()
        {
            using var db = new HotelDbContext();
            return db.Guests.ToList();
        }

        public void Update(Guest guest)
        {
            using var db = new HotelDbContext();
            db.Guests.Update(guest);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HotelDbContext();
            var g = db.Guests.Find(id);
            if (g != null)
            {
                db.Guests.Remove(g);
                db.SaveChanges();
            }
        }
    }
}
