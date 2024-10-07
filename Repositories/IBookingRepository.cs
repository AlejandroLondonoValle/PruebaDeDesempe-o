using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IBookingRepository
{
    Task Add(Booking booking);
    Task<Booking?> GetByIdentificationNumber(string identification_number);
    Task<Booking?> GetById(int id);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
