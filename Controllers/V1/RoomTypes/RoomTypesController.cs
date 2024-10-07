using Microsoft.AspNetCore.Mvc;
using HotelApiRestFull.Repositories;
namespace HotelApiRestFull.Controllers.V1.RoomTypes;

[ApiController]
[Route("api/v1/room_types")]
public partial class RoomTypesController(IRoomTypeRepository roomTypeRepository) : ControllerBase
{
    protected readonly IRoomTypeRepository _roomTypeRepository = roomTypeRepository;
}
