using HotelApiRestFull.Data;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
namespace HotelApiRestFull.Services;

public class BookingServices : IBookingRepository
{
    private readonly ApplicationDbContext _context;

    public BookingServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task Add(Booking booking)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckExistence(int id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Booking>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Booking?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Booking booking)
    {
        throw new NotImplementedException();
    }
}
