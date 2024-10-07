using System.ComponentModel.DataAnnotations;
namespace HotelApiRestFull.DTOs.Request;

public class BookingDTO
{
    [Required(ErrorMessage = "El Id de la reserva es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id de la reserva debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id de la reserva")]
    public int Id { get; set; }


    [Required(ErrorMessage = "El Id de la habitacion es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id de la habitacion debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id de la habitacion")]
    public int RoomId { get; set; }


    [Required(ErrorMessage = "El Id del huesped es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del huesped debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del huesped")]
    public int GuestId { get; set; }


    [Required(ErrorMessage = "El Id del empleado es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del empleado debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del empleado")]
    public int EmployeeId { get; set; }


    [Required(ErrorMessage = "La fecha de inicio es requerida.")]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de inicio")]
    public DateTime StartDate { get; set; }


    [Required(ErrorMessage = "La fecha de fin es requerida.")]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de fin")]
    public DateTime EndDate { get; set; }


    [Required(ErrorMessage = "El costo total es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El costo total debe ser un número positivo mayor o igual a 0.")]
    [Display(Name = "Costo total")]
    public double TotalCost { get; set; }

}
