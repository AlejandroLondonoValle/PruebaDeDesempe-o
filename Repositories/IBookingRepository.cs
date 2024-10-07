using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IBookingRepository
{
    Task Add(Booking booking);
    Task<IEnumerable<Booking>> GetAll();
    Task<Booking?> GetById(int id);
    Task Update(Booking booking);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
