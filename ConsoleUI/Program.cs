using CampingLibrary.Models.Generators;
using CampingLibrary.Models.Guests;

List<IGuest> guests = GuestGenerator.GenerateGuests(15);

foreach (var guest in guests)
{
    Console.WriteLine($"{guest.GuestId} - {guest.Firstname} {guest.Lastname}");
}   


