using HotelApiRestFull.DTOs.Request;
using HotelApiRestFull.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Guests;


public partial class GuestsController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Guest>> Create(GuestDTO inputGuest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newGuest = new Guest();

        await _guestRepository.Add(newGuest);

        return Ok(newGuest);
    }
}
