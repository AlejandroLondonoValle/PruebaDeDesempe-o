using HotelApiRestFull.Data;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.EntityFrameworkCore;
namespace HotelApiRestFull.Services;

public class RoomTypeServices : IRoomTypeRepository
{
    private readonly ApplicationDbContext _context;

    public RoomTypeServices(ApplicationDbContext context)
    {
        _context = context;
    }

    
    public async Task<IEnumerable<RoomType>> GetAll()
    {
        return await _context.RoomTypes.ToListAsync();
    }
    public async Task<RoomType?> GetById(int id)
    {
        return await _context.RoomTypes.FindAsync(id);
    }
    
}
