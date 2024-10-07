using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IEmployeeRepository
{
    Task Add(Employee employee);
    Task<IEnumerable<Employee>> GetAll();
    Task<Employee?> GetById(int id);
    Task Update(Employee employee);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
    Task<string?> Login(string email, string password);
    Task<Employee?> ValidateEmployee(string email, string password);
    public Employee GetEmployeeByEmail(string email);


}
