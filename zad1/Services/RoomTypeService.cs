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
        private readonly RoomTypeRepository repository = new();

        public void AddRoomType(RoomType type)
        {
            if (type.PricePerNight <= 0)
                throw new Exception("Invalid price");

            repository.Add(type);
        }

        public List<RoomType> GetRoomTypes()
        {
            return repository.GetAll();
        }

        public RoomType GetRoomType(int id)
        {
            return repository.Get(id);
        }

       
        public void UpdateRoomType(RoomType type)
        {
            if (type == null)
                throw new Exception("RoomType is null");

            if (type.PricePerNight <= 0)
                throw new Exception("Invalid price");

            repository.Update(type);
        }

        
        public void DeleteRoomType(int id)
        {
            repository.Delete(id);
        }

    }
}
