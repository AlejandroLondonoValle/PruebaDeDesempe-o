using HotelApiRestFull.Models;
using Microsoft.AspNetCore.Mvc;
namespace HotelApiRestFull.Controllers.V1.RoomTypes;

public partial class RoomTypesController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RoomType>>> GetAll()
    {
        var roomTypes = await _roomTypeRepository.GetAll();
        if (roomTypes == null || !roomTypes.Any())
        {
            return NotFound();
        }

        return Ok(roomTypes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RoomType>> GetById(int id)
    {
        var roomTypes = await _roomTypeRepository.GetById(id);
        if (roomTypes == null)
        {
            return NotFound();
        }
        return roomTypes;
    }
}
