using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.DTOs.Response;
using HotelApiRestFull.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Rooms;

public partial class RoomsController : ControllerBase
{
    [HttpGet("available")]
    public async Task<ActionResult<IEnumerable<Room>>> GetAvailable()
    {
        var room = await _roomRepository.GetAll();
        if (room == null || !room.Any())
        {
            return NotFound();
        }

        return Ok(room);
    }

    [HttpGet("status")]
    public async Task<ActionResult<RoomStatusDTO>> GetRoomStatus()
    {
        var status = await _roomRepository.GetRoomStatus();
        return Ok(status);
    }

    [Authorize]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Room>>> GetAll()
    {
        var room = await _roomRepository.GetAll();
        if (room == null || !room.Any())
        {
            return NotFound();
        }

        return Ok(room);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<ActionResult<Room>> GetById(int id)
    {
        var room = await _roomRepository.GetById(id);
        if (room == null)
        {
            return NotFound();
        }
        return room;
    }

    [Authorize]
    [HttpGet("occupied")]
    public async Task<ActionResult<IEnumerable<Room>>> GetOccupied()
    {
        var room = await _roomRepository.GetAll();
        if (room == null || !room.Any())
        {
            return NotFound();
        }

        return Ok(room);
    }


}
