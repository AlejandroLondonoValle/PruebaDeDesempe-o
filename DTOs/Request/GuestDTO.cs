using System.ComponentModel.DataAnnotations;
namespace HotelApiRestFull.DTOs.Request;

public class GuestDTO
{
    [Required(ErrorMessage = "El Id del huesped es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del huesped debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del huesped")]
    public int Id { get; set; }


    [Required(ErrorMessage = "El Primer nombre del huesped es obligatorio.")]
    [StringLength(255, ErrorMessage = "El Primer nombre del huesped no puede exceder los 255 caracteres.")]
    [Display(Name = "Primer nombre del huesped")]
    public required string FirstName { get; set; }


    [Required(ErrorMessage = "El Ultimo nombre del huesped es obligatorio.")]
    [StringLength(255, ErrorMessage = "El Ultimo nombre del huesped no puede exceder los 50 caracteres.")]
    [Display(Name = "Ultimo nombre del huesped")]
    public required string LastName { get; set; }


    [Required(ErrorMessage = "El correo electronico del huesped es obligatorio.")]
    [StringLength(255, ErrorMessage = "El correo electronico del huesped no puede exceder los 255 caracteres.")]
    [Display(Name = "correo electronico del huesped")]
    public required string Email { get; set; }


    [Required(ErrorMessage = "El numero de identificacion del huesped es obligatorio.")]
    [StringLength(20, ErrorMessage = "El numero de identificacion del huesped no puede exceder los 20 caracteres.")]
    [Display(Name = "numero de identificacion del huesped")]
    public required string IdentificationNumber { get; set; }


    [Required(ErrorMessage = "El numero de telefono del huesped es obligatorio.")]
    [StringLength(20, ErrorMessage = "El numero de telefono del huesped no puede exceder los 20 caracteres.")]
    [Display(Name = "numero de telefono del huesped")]
    public required string PhoneNumber { get; set; }


    [Display(Name = "fecha de nacimiento del huesped")]
    [DataType(DataType.Date)]
    [FutureDateValidation(ErrorMessage = "La fecha del pedido no puede ser una fecha futura.")]
    public DateTime? Birthdate { get; set; }
}

public class FutureDateValidationAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date && date > DateTime.Now)
        {
            return new ValidationResult(ErrorMessage);
        }
        return ValidationResult.Success;
    }
}
