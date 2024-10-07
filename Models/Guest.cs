using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HotelApiRestFull.Models;


[Table("guests")]
public class Guest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("identification_number")]
    public string? IdentificationNumber { get; set; }

    [Column("phone_number")]
    public string? PhoneNumber { get; set; }

    [Column("birthdate")]
    public DateTime? Birthdate { get; set; }
}
