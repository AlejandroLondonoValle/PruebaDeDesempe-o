using HotelApiRestFull.Data;
using HotelApiRestFull.DTOs.Request;
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

    public async Task<Booking> Add(BookingDTO booking)
    {
        if (booking == null)
        {
            throw new ArgumentNullException(nameof(booking), "La reserva no puede ser nula.");
        }

        try
        {
            var newBooking = new Booking
            {
                RoomId = booking.RoomId,
                GuestId = booking.GuestId,
                EmployeeId = booking.EmployeeId,
                StartDate = booking.StartDate,
                EndDate = booking.EndDate,
                TotalCost = booking.TotalCost,
            };

            await _context.Bookings.AddAsync(newBooking);
            await _context.SaveChangesAsync();
            return newBooking;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear la reserva", ex);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Bookings.AnyAsync(o => o.Id == id);
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar la orden a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar la orden.", ex);
        }
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Booking?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Booking?> GetByIdentificationNumber(string identification_number)
    {
        throw new NotImplementedException();
    }
}
