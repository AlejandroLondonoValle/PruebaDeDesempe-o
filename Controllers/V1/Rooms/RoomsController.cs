using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Rooms;

[ApiController]
[Route("api/v1/rooms")]
public partial class RoomsController(IRoomRepository roomRepository) : ControllerBase
{
    protected readonly IRoomRepository _roomRepository = roomRepository;
}
