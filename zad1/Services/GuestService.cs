using HotelSystem.Models;
using HotelSystem.Repository;
namespace HotelSystem.Services
{
    public class GuestService
    {
        private readonly GuestRepository guestRepository = new();

        public void RegisterGuest(Guest guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FullName))
                throw new Exception("Invalid guest name");

            guestRepository.Add(guest);
        }

        public Guest GetGuest(int id)
        {
            return guestRepository.Get(id);
        }

        public List<Guest> GetAllGuests()
        {
            return guestRepository.GetAll();
        }

        public void UpdateGuest(Guest guest)
        {
            if (guest == null)
                throw new Exception("Guest is null");

            if (string.IsNullOrWhiteSpace(guest.FullName))
                throw new Exception("Invalid guest name");

            guestRepository.Update(guest);
        }

        
        public void DeleteGuest(int id)
        {
            guestRepository.Delete(id);
        }
    }
}
