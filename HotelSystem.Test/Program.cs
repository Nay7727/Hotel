using System;
using HotelSystem.Models;
using HotelSystem.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== HOTEL SYSTEM TEST ===");

        // === 1. Guest ===
        var guestService = new GuestService();
        var guest = new Guest { FullName = "Ivan Ivanov", Phone = "0888123456" };
        guestService.RegisterGuest(guest);
        Console.WriteLine($"Guest added: {guest.FullName}");

        var allGuests = guestService.GetAllGuests();
        Console.WriteLine($"Total guests: {allGuests.Count}");

        // Update
        var firstGuest = allGuests[0];
        firstGuest.Phone = "0899999999";
        guestService.RegisterGuest(firstGuest); // можем да използваме същия метод
        Console.WriteLine($"Guest updated: {firstGuest.FullName}, new phone: {firstGuest.Phone}");

        // === 2. RoomType ===
        var roomTypeService = new RoomTypeService();
        var type = new RoomType { TypeName = "Single", PricePerNight = 50m };
        roomTypeService.AddRoomType(type);
        Console.WriteLine($"Room type added: {type.TypeName}, {type.PricePerNight} per night");

        // === 3. HotelRoom ===
        var hotelRoomService = new HotelRoomService();
        var room = new HotelRoom { RoomNumber = 101, RoomType = type };
        hotelRoomService.AddRoom(room);
        Console.WriteLine($"Hotel room added: {room.RoomNumber}, type: {room.RoomType.TypeName}");

        // === 4. Reservation ===
        var reservationService = new ReservationService();
        var reservation = new Reservation
        {
            Guest = firstGuest,
            Room = room,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddDays(3)
        };
        reservationService.CreateReservation(reservation);
        Console.WriteLine($"Reservation added for guest {reservation.Guest.FullName} in room {reservation.Room.RoomNumber}");

        // === 5. Payment ===
        var paymentService = new PaymentService();
        var payment = new Payment
        {
            Reservation = reservation,
            Amount = 150m
        };
        paymentService.Pay(payment);
        Console.WriteLine($"Payment added: {payment.Amount} for reservation in room {payment.Reservation.Room.RoomNumber}");

        // === List all data ===
        Console.WriteLine("\n=== All Guests ===");
        foreach (var g in guestService.GetAllGuests())
            Console.WriteLine($"{g.Id}: {g.FullName}, {g.Phone}");

        Console.WriteLine("\n=== All Room Types ===");
        foreach (var rt in roomTypeService.GetRoomTypes())
            Console.WriteLine($"{rt.Id}: {rt.TypeName}, {rt.PricePerNight}");

        Console.WriteLine("\n=== All Rooms ===");
        foreach (var r in hotelRoomService.GetAllRooms())
            Console.WriteLine($"{r.Id}: Room {r.RoomNumber}, Type: {r.RoomType.TypeName}");

        Console.WriteLine("\n=== All Reservations ===");
        foreach (var res in reservationService.GetReservations())
            Console.WriteLine($"{res.Id}: Guest {res.Guest.FullName}, Room {res.Room.RoomNumber}, From {res.StartDate.ToShortDateString()} To {res.EndDate.ToShortDateString()}");

        Console.WriteLine("\n=== All Payments ===");
        foreach (var p in paymentService.GetPayments())
            Console.WriteLine($"{p.Id}: Reservation {p.Reservation.Id}, Amount {p.Amount}, PaidOn {p.PaymentDate}");

        Console.WriteLine("\n=== TEST COMPLETE ===");
    }
}

