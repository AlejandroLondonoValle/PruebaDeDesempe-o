using System.ComponentModel.DataAnnotations;
namespace HotelApiRestFull.DTOs.Request;

public class EmployeeDTO
{
    [Required(ErrorMessage = "El Primer nombre del empleado es obligatorio.")]
    [StringLength(50, ErrorMessage = "El Primer nombre del empleado no puede exceder los 50 caracteres.")]
    [Display(Name = "Primer nombre del empleado")]
    public required string FirstName { get; set; }


    [Required(ErrorMessage = "El Ultimo nombre del empleado es obligatorio.")]
    [StringLength(50, ErrorMessage = "El Ultimo nombre del empleado no puede exceder los 50 caracteres.")]
    [Display(Name = "Ultimo nombre del empleado")]
    public required string LastName { get; set; }


    [Required(ErrorMessage = "El correo electronico del empleado es obligatorio.")]
    [StringLength(255, ErrorMessage = "El correo electronico del empleado no puede exceder los 255 caracteres.")]
    [Display(Name = "correo electronico del empleado")]
    public required string Email { get; set; }


    [Required(ErrorMessage = "El numero de identificacion del empleado es obligatorio.")]
    [StringLength(20, ErrorMessage = "El numero de identificacion del empleado no puede exceder los 20 caracteres.")]
    [Display(Name = "numero de identificacion del empleado")]
    public required string IdentificationNumber { get; set; }


    [Required(ErrorMessage = "La contraseña del empleado es obligatorio.")]
    [StringLength(255, ErrorMessage = "La contraseña del empleado no puede exceder los 255 caracteres.")]
    [Display(Name = "contraseña del empleado")]
    public required string Password { get; set; }


}
