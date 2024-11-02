namespace Reservation.API.Infrastructure;

public interface IReservationService
{
    public void Create(Models.Reservation Reservation);

    public Models.Reservation GetReservation();

    public Models.Reservation GetReservationById(Guid Id);
}
