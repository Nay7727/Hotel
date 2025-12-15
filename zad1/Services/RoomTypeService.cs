using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services
{
    public class RoomTypeService
    {
        public void Add(RoomType rt)
        {
            using var db = new HotelDbContext();
            db.RoomTypes.Add(rt);
            db.SaveChanges();
        }

        public RoomType Get(int id)
        {
            using var db = new HotelDbContext();
            return db.RoomTypes.Find(id);
        }

        public List<RoomType> GetAll()
        {
            using var db = new HotelDbContext();
            return db.RoomTypes.ToList();
        }

        public void Update(RoomType rt)
        {
            using var db = new HotelDbContext();
            db.RoomTypes.Update(rt);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HotelDbContext();
            var rt = db.RoomTypes.Find(id);
            if (rt != null)
            {
                db.RoomTypes.Remove(rt);
                db.SaveChanges();
            }
        }
    }
}
