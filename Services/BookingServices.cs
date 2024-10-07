using HotelApiRestFull.Data;
using HotelApiRestFull.DTOs.Response;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.EntityFrameworkCore;
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
            return await _context.Bookings.AnyAsync(b => b.Id == id);
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar la reserva a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar la reserva.", ex);
        }
    }
    public async Task Delete(int id)
    {
        var booking = await _context.Bookings.FindAsync(id);
        if (booking != null)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<BookingDTO?> GetById(int id)
    {
        var booking = await _context.Bookings.
         Include(b => b.Guest).
         Include(b => b.Employee).
         Include(b => b.Room.RoomType).
         FirstOrDefaultAsync(b => b.Id == id);

         if (booking == null)
         {
             return null;
         }

         return new BookingDTO
         {
            Id = booking.Id,
            StartDate = booking.StartDate,
            EndDate = booking.EndDate,
            TotalCost = booking.TotalCost,
            Room = booking.Room,
            Guest = booking.Guest,
            Employee = booking.Employee,
         };
    }

    public async Task<Booking?> GetByIdentificationNumber(string identification_number)
    {
        return await _context.Bookings.FirstOrDefaultAsync(b => b.Guest.IdentificationNumber == identification_number);
    }
}
