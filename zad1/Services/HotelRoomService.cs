using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services
{
    public class HotelRoomService
    {
        public void Add(HotelRoom room)
        {
            using var db = new HotelDbContext();
            db.HotelRooms.Add(room);
            db.SaveChanges();
        }

        public HotelRoom Get(int id)
        {
            using var db = new HotelDbContext();
            return db.HotelRooms.Find(id);
        }

        public List<HotelRoom> GetAll()
        {
            using var db = new HotelDbContext();
            return db.HotelRooms.ToList();
        }

        public void Update(HotelRoom room)
        {
            using var db = new HotelDbContext();
            db.HotelRooms.Update(room);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HotelDbContext();
            var r = db.HotelRooms.Find(id);
            if (r != null)
            {
                db.HotelRooms.Remove(r);
                db.SaveChanges();
            }
        }
    }
}
