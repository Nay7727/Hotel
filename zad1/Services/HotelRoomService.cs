using HotelSystem.Models;
using HotelSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services
{
    public class HotelRoomService
    {
        private readonly HotelRoomRepository repository = new();

        public void AddRoom(HotelRoom room)
        {
            if (room.RoomNumber <= 0)
                throw new Exception("Invalid room number");

            repository.Add(room);
        }

        public List<HotelRoom> GetAllRooms()
        {
            return repository.GetAll();
        }
    }
}
