using HotelApiRestFull.Data;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.EntityFrameworkCore;
namespace HotelApiRestFull.Services;

public class GuestServices : IGuestRepository
{
    private readonly ApplicationDbContext _context;

    public GuestServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Add(Guest guest)
    {
        if (guest == null)
        {
            throw new ArgumentNullException(nameof(guest), "El huesped no puede ser nula.");
        }

        try
        {
            await _context.Guests.AddAsync(guest);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar El huesped a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar El huesped.", ex);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Guests.AnyAsync(g => g.Id == id);
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar el huesped a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar el huesped.", ex);
        }
    }

    public async Task Delete(int id)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest != null)
        {
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Guest>> GetAll()
    {
        return await _context.Guests.ToListAsync();
    }

    public async Task<Guest?> GetById(int id)
    {
        return await _context.Guests.FindAsync(id);
    }

    public async Task Update(Guest guest)
    {
        if (guest == null)
        {
            throw new ArgumentNullException(nameof(guest), "El huesped no puede ser nulo.");
        }

        try
        {
            _context.Entry(guest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al actualizar el huesped en la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al actualizar el huesped.", ex);
        }
    }

    public async Task<Guest?> GetBykeyword(string keyword)
    {
        return await _context.Guests.FindAsync(keyword);
    }
}
