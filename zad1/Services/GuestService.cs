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
    }
}
