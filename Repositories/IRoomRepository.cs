using HotelApiRestFull.DTOs.Response;
using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAll();
    Task<Room?> GetById(int id);
    Task<IEnumerable<Room>> GetAvailable();
    Task<RoomStatusDTO> GetRoomStatus();
    Task<IEnumerable<Room>> GetOccupied();
}
