using HotelApiRestFull.Data;
using HotelApiRestFull.DTOs.Response;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.EntityFrameworkCore;
namespace HotelApiRestFull.Services;

public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Room>> GetAll()
    {
        return await _context.Rooms.Include(r=> r.RoomType).ToListAsync();
    }

    public async Task<IEnumerable<Room>> GetAvailable()
    {
        return await _context.Rooms.Where(r => r.Availability == true).ToListAsync();
    }

    public async Task<Room?> GetById(int id)
    {
        return await _context.Rooms.Include(r=> r.RoomType).FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<RoomStatusDTO> GetRoomStatus()
    {
        var totalRooms = await _context.Rooms.CountAsync();
        var availableRooms = await _context.Rooms.CountAsync(r => r.Availability == true);
        var occupiedRooms = totalRooms - availableRooms;

        return new RoomStatusDTO
        {
            TotalRooms = totalRooms,
            AvailableRooms = availableRooms,
            OccupiedRooms = occupiedRooms
        };

    }

    public async Task<IEnumerable<Room>> GetOccupied()
    {
        return await _context.Rooms.Where(r => r.Availability == false).ToListAsync();
    }
}
