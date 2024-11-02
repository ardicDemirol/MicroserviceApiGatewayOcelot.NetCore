using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;

namespace Reservation.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationController(IReservationService ReservationService) : ControllerBase
{
    private readonly IReservationService reservationService = ReservationService;

    [HttpGet]
    public Models.Reservation Get()
    {
        return reservationService.GetReservation();
    }


    [HttpGet("{Id}")]
    public Models.Reservation GetResById(Guid Id)
    {
        return reservationService.GetReservationById(Id);
    }
}
