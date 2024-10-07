using HotelApiRestFull.Data;
using HotelApiRestFull.Helpers;
using HotelApiRestFull.Models;
using HotelApiRestFull.Repositories;
using Microsoft.EntityFrameworkCore;
namespace HotelApiRestFull.Services;

public class EmployeeServices : IEmployeeRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Add(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee), "El empleado no puede ser nulo.");
        }

        if (string.IsNullOrWhiteSpace(employee.Password))
        {
            throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(employee.Password));
        }

        try
        {

            employee.Password = PasswordHasher.HashPassword(employee.Password);

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar el empleado a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar el empelado.", ex);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Employees.AnyAsync(e => e.Id == id);
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar el empleado a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar el empleado.", ex);
        }
    }

    public async Task Delete(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Employee>> GetAll()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetById(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<string?> Login(string email, string password)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        if (employee == null)
        {
            return null;
        }

        bool isPasswordValid = PasswordHasher.VerifyPassword(password, employee.Password);
        if (!isPasswordValid)
        {
            return null;
        }

        var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
        var audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        var secretKey = Environment.GetEnvironmentVariable("JWT_SECRET_KEY");

        return JwtTokenHelper.GenerateToken(employee.FirstName, secretKey, issuer, audience);
    }

    public async Task Update(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee), "El empleado no puede ser nulo.");
        }

        try
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al actualizar el empleado en la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al actualizar el empleado.", ex);
        }
    }

    public async Task<Employee?> ValidateEmployee(string email, string password)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        if (employee == null)
        {
            return null;
        }

        bool isPasswordValid = PasswordHasher.VerifyPassword(password, employee.Password);

        if (!isPasswordValid)
        {
            return null;
        }

        return employee;
    }

    public Employee GetEmployeeByEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email cannot be null or empty", nameof(email));
        }

        return _context.Employees.FirstOrDefault(e => e.Email == email);
    }

}
