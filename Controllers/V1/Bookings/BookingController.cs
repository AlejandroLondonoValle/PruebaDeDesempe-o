using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiRestFull.Controllers.V1.Bookings
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class BookingController(IBookingRepository bookingRepository) : ControllerBase
    {
        protected readonly IBookingRepository _bookingRepository = bookingRepository;
    }
}