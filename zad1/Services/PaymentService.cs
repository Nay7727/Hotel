using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HotelSystem.Services
{
    public class PaymentService
    {
        public void Add(Payment p)
        {
            using var db = new HotelDbContext();
            db.Payments.Add(p);
            db.SaveChanges();
        }

        public Payment Get(int id)
        {
            using var db = new HotelDbContext();
            return db.Payments.Find(id);
        }

        public List<Payment> GetAll()
        {
            using var db = new HotelDbContext();
            return db.Payments.ToList();
        }

        public void Update(Payment p)
        {
            using var db = new HotelDbContext();
            db.Payments.Update(p);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new HotelDbContext();
            var p = db.Payments.Find(id);
            if (p != null)
            {
                db.Payments.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
