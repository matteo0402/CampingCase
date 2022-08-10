using CampingLibrary.Models.Guests;

namespace CampingLibrary.Models.Generators;

public static class GuestGenerator
{
    public static List<IGuest> GenerateGuests(int amount)
    {
        List<IGuest> guests = new List<IGuest>();
        for (int i = 0; i < amount; i++)
        {
            guests.Add(new Guest() { GuestId = GenerateId(), Firstname = "Klaus", Lastname = "Knudsen"});
        }

        return guests;
    }
    
    private static int GenerateId()
    {
        Random rnd = new Random();
        return rnd.Next(15000, 19999);
    }
}