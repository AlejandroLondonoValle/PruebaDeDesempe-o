using System.ComponentModel.DataAnnotations;
namespace HotelApiRestFull.DTOs.Request;

public class RoomDTO
{
    [Required(ErrorMessage = "El Id de la habitacion es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id de la habitacion debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id de la habitacion")]
    public int Id { get; set; }


    [Required(ErrorMessage = "El numero de la habitacion es obligatorio.")]
    [StringLength(10, ErrorMessage = "El numero de la habitacion no puede exceder los 10 caracteres.")]
    [Display(Name = "numero de la habitacion")]
    public required string Number { get; set; }


    [Required(ErrorMessage = "El precio por noche es requerido.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio por noche tiene que ser un número positivo mayor a 0.")]
    [DataType(DataType.Currency, ErrorMessage = "El precio por noche tiene que estar en un formato válido.")]
    [Display(Name = "precio por noche")]
    public double Price { get; set; }


    [Required(ErrorMessage = "La disponibilidad del empleado es obligatoria.")]
    [Display(Name = "Disponibilidad del empleado")]
    public bool Availability { get; set; }


    [Required(ErrorMessage = "El maximo de aforo es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El maximo de aforo debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Aforo de la habitacion")]
    public int Occupancy { get; set; }


    [Required(ErrorMessage = "El Id del tipo de habitacion es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del tipo de habitacion debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del tipo de habitacion")]
    public int RoomTypeId { get; set; }

}
