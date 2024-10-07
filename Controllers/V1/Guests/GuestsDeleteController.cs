using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.DTOs.Request;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Guests;


public partial class GuestsController : ControllerBase
{
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var guest = await _guestRepository.CheckExistence(id);
        if (guest == false)
        {
            return NotFound();
        }

        await _guestRepository.Delete(id);

        return NoContent();
    }
}


