using Nomina.API.Models;

namespace Nomina.API.Repository.Interfaces;

public interface INominaRepository
{
    Task<IEnumerable<NominaItem>> GetAllNominas();
    Task<NominaItem> GetNominaById(int id);
    
    // CRUD
    Task<NominaItem> AddNomina(NominaItem nomina);
    Task<NominaItem> UpdateNomina(NominaItem nomina);
    Task<bool> DeleteNomina(int id);
}