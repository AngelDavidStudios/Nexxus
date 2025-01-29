using Amazon.DynamoDBv2.DataModel;
using Parametros.API.Models;
using Parametros.API.Repository.Interfaces;

namespace Parametros.API.Repository;

public class ParametroRepository: IParametroInterface
{
    private readonly IDynamoDBContext _context;
    
    public ParametroRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<ParametroItem>> GetAllParametros()
    {
        var conditions = new List<ScanCondition>();
        var allParametros = await _context.ScanAsync<ParametroItem>(conditions).GetRemainingAsync();
        return allParametros;
    }
    
    public async Task<ParametroItem> GetParametroById(int id)
    {
        return await _context.LoadAsync<ParametroItem>(id.ToString());
    }
    
    public async Task<ParametroItem> AddParametro(ParametroItem parametro)
    {
        parametro.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(parametro);
        return parametro;
    }
    
    public async Task<ParametroItem> UpdateParametro(ParametroItem parametro)
    {
        await _context.SaveAsync(parametro);
        return parametro;
    }
    
    public async Task<bool> DeleteParametro(int id)
    {
        var parametro = await GetParametroById(id);
        if (parametro == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<ParametroItem>(id.ToString());
        return true;
    }
}