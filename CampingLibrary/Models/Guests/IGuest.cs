namespace CampingLibrary.Models.Guests;

public interface IGuest
{
    int GuestId { get; set; }
    string? Firstname { get; set; }
    string? Lastname { get; set; }
}