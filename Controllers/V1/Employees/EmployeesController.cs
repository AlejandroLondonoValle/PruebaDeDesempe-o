using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Employees;

[ApiController]
[Route("api/v1/employees")]
public partial class EmployeesController(IEmployeeRepository employeeRepository) : ControllerBase
{
    protected readonly IEmployeeRepository _employeeRepository = employeeRepository;
}
