using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HotelApiRestFull.DTOs.Request;
using HotelApiRestFull.Repositories;
using HotelApiRestFull.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HotelApiRestFull.Controllers.AuthController
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public AuthController(IEmployeeRepository employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO login)
        {
            if (login == null)
            {
                return BadRequest("Invalid login request");
            }

            var employee = _employeeService.GetEmployeeByEmail(login.Email);
            if (employee == null)
            {
                return Unauthorized("Employee not found");
            }

            if (!BCrypt.Net.BCrypt.Verify(login.Password, employee.Password))
            {
                return Unauthorized("Invalid password");
            }

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, employee.FirstName),
        };

            var token = new JwtSecurityToken(
                issuer: Environment.GetEnvironmentVariable("JWT_ISSUER"),
                audience: Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET_KEY"))),
                    SecurityAlgorithms.HmacSha256
                )
            );

            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                employee.Email
            });
        }
    }
}