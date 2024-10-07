using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.Models;

namespace HotelApiRestFull.Repositories
{
    public interface IRoomTypeRepository
    {

        Task<IEnumerable<RoomType>> GetAll();
        Task<RoomType?> GetById(int id);
    }
}