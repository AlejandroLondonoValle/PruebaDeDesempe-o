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
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
    {
        var guests = await _guestRepository.GetAll();
        if (guests == null || !guests.Any())
        {
            return NotFound();
        }

        return Ok(guests);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<ActionResult<Guest>> GetById(int id)
    {
        var guests = await _guestRepository.GetById(id);
        if (guests == null)
        {
            return NotFound();
        }
        return guests;
    }

    [Authorize]
    [HttpGet("keyword")]
    public async Task<ActionResult<Guest>> GetByKeyword(string keyword)
    {
        var guests = await _guestRepository.GetBykeyword(keyword);
        if (guests == null)
        {
            return NotFound();
        }
        return guests;
    }
}


