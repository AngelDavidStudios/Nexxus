using Parametros.API.Models;

namespace Parametros.API.Repository.Interfaces;

public interface IParametroInterface
{
    Task<IEnumerable<ParametroItem>> GetAllParametros();
    Task<ParametroItem> GetParametroById(int id);
    
    // CRUD
    Task<ParametroItem> AddParametro(ParametroItem parametro);
    Task<ParametroItem> UpdateParametro(ParametroItem parametro);
    Task<bool> DeleteParametro(int id);
}