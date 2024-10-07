using HotelApiRestFull.DTOs.Request;
using HotelApiRestFull.Models;
using Microsoft.AspNetCore.Mvc;
namespace HotelApiRestFull.Controllers.V1.Employees;

public partial class EmployeesController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Employee>> Create(EmployeeDTO inputEmployee)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newEmployee = new Employee
        {
            FirstName = inputEmployee.FirstName,
            LastName = inputEmployee.LastName,
            Email = inputEmployee.Email,
            IdentificationNumber = inputEmployee.IdentificationNumber,
            Password = inputEmployee.Password
        };

        try
        {
            await _employeeRepository.Add(newEmployee);
            return Ok(newEmployee);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ocurrió un error al crear el empelado: {ex.Message}");
        }
    }
}
