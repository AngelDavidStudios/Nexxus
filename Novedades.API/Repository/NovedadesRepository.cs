using Amazon.DynamoDBv2.DataModel;
using Novedades.API.Models;
using Novedades.API.Repository.Interfaces;

namespace Novedades.API.Repository;

public class NovedadesRepository: INovedadesRepository
{
    private readonly IDynamoDBContext _context;
    
    public NovedadesRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<NovedadesItem>> GetAllNovedades()
    {
        var conditions = new List<ScanCondition>();
        var allNovedades = await _context.ScanAsync<NovedadesItem>(conditions).GetRemainingAsync();
        return allNovedades;
    }
    
    public async Task<NovedadesItem> GetNovedadesById(int id)
    {
        return await _context.LoadAsync<NovedadesItem>(id.ToString());
    }
    
    public async Task<NovedadesItem> AddNovedades(NovedadesItem novedades)
    {
        novedades.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(novedades);
        return novedades;
    }
    
    public async Task<NovedadesItem> UpdateNovedades(NovedadesItem novedades)
    {
        await _context.SaveAsync(novedades);
        return novedades;
    }
    
    public async Task<bool> DeleteNovedades(int id)
    {
        var novedades = await GetNovedadesById(id);
        if (novedades == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<NovedadesItem>(id.ToString());
        return true;
    }
}