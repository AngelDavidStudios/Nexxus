using Novedades.API.Models;

namespace Novedades.API.Repository.Interfaces;

public interface INovedadesRepository
{
    Task<IEnumerable<NovedadesItem>> GetAllNovedades();
    Task<NovedadesItem> GetNovedadesById(int id);
    
    // CRUD
    Task<NovedadesItem> AddNovedades(NovedadesItem novedades);
    Task<NovedadesItem> UpdateNovedades(NovedadesItem novedades);
    Task<bool> DeleteNovedades(int id);
}