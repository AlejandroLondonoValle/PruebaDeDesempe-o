using HotelApiRestFull.Models;
namespace HotelApiRestFull.Repositories;

public interface IGuestRepository
{
    Task Add(Guest guest);
    Task<IEnumerable<Guest>> GetAll();
    Task<Guest?> GetById(int id);
    Task Update(Guest guest);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

    Task<Guest?> GetBykeyword(string keyword);
}
