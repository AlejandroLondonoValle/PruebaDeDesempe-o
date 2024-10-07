using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HotelApiRestFull.Models;


[Table("bookings")]
public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_id")]
    public int RoomId { get; set; }

    [ForeignKey("RoomId")]
    public Room? Room { get; set; }

    [Column("guest_id")]
    public int GuestId { get; set; }

    [ForeignKey("GuestId")]
    public Guest? Guest { get; set; }

    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [ForeignKey("EmployeeId")]
    public Employee? Employee { get; set; }


    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    public DateTime EndDate { get; set; }

    [Column("total_cost")]
    public double TotalCost { get; set; }

}
