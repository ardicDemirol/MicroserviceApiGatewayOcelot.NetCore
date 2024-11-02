namespace Reservation.API.Models;
public class Reservation
{
    public Guid Id { get; set; }

    public DateTime? CheckInDate { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public DateTime? ResDate { get; set; }

    public double Amount { get; set; }

    public Guid OwnerContact { get; set; }
}
