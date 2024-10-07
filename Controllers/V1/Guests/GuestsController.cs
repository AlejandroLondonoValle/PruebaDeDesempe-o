using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace HotelApiRestFull.Controllers.V1.Guests;

[ApiController]
[Route("api/guests")]
public partial class GuestsController(IGuestRepository guestRepository) : ControllerBase
{
    protected readonly IGuestRepository _guestRepository = guestRepository;
}
