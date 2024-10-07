using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.DTOs.Request;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Guests
{

    public partial class GuestsController : ControllerBase
    {
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, GuestDTO updatedGuest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var checkGuest = await _guestRepository.CheckExistence(id);
            if (checkGuest == false)
            {
                return NotFound();
            }

            var guest = await _guestRepository.GetById(id);

            if (guest == null)
            {
                return NotFound();
            }

            guest.FirstName = updatedGuest.FirstName;
            guest.LastName = updatedGuest.LastName;
            guest.Email = updatedGuest.Email;
            guest.IdentificationNumber = updatedGuest.IdentificationNumber;
            guest.PhoneNumber = updatedGuest.PhoneNumber;
            guest.Birthdate = updatedGuest.Birthdate;

            await _guestRepository.Update(guest);
            return NoContent();
        }
    }
}