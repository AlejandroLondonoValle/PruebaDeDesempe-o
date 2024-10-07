using HotelApiRestFull.DTOs.Response;
using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IBookingRepository
{
    Task<Booking> Add(BookingDTO booking);
    Task<Booking?> GetByIdentificationNumber(string identification_number);
    Task<BookingDTO?> GetById(int id);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
