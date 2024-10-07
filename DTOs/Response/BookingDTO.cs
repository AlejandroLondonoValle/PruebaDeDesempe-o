using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.Models;

namespace HotelApiRestFull.DTOs.Response
{
    public class BookingDTO
    {

        public int Id { get; set; }
        public Guest? Guest { get; set; }
        public Employee? Employee { get; set; }
        public Room? Room { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalCost { get; set; }
    }
}