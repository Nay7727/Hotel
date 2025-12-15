using HotelSystem;
using HotelSystem.Services;

class Program
{
    static void Main()
    {
        using (var db = new HotelDbContext())
        {
            db.Database.EnsureCreated();
        }

        Console.WriteLine("Database ready.");
    }
}