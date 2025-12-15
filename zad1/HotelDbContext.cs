using HotelSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem
{

    public class HotelDbContext : DbContext
    {
        public HotelDbContext() { }

        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options) { }

        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    AppSettings.ConnectionString,
                    ServerVersion.AutoDetect(AppSettings.ConnectionString)
                );
            }
        }
    }
}
