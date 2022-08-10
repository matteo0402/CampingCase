namespace CampingLibrary.Models.Guests;

public class Guest : IGuest
{
    public int GuestId { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
}