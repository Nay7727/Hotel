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

        public HotelRoom GetRoom(int id)
        {
            return repository.Get(id);
        }

        
        public void UpdateRoom(HotelRoom room)
        {
            if (room == null)
                throw new Exception("Room is null");

            if (room.RoomNumber <= 0)
                throw new Exception("Invalid room number");

            repository.Update(room);
        }

       
        public void DeleteRoom(int id)
        {
            repository.Delete(id);
        }

    }
}
