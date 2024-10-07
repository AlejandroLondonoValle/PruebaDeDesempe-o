using System.ComponentModel.DataAnnotations;
namespace HotelApiRestFull.DTOs.Request;

public class RoomTypeDTO
{
    [Required(ErrorMessage = "El Id del tipo de habitacion es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del tipo de habitacion debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del tipo de habitacion")]
    public int Id { get; set; }


    [Required(ErrorMessage = "El nombre del tipo de habitacion es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre del tipo de habitacion no puede exceder los 10 caracteres.")]
    [Display(Name = "El nombre del tipo de habitacion")]
    public required string Name { get; set; }


    [StringLength(255, ErrorMessage = "La descripcion del tipo de habitacion no puede exceder los 255 caracteres.")]
    [Display(Name = "La descripcion del tipo de habitacion")]
    public string? Description { get; set; }
}
