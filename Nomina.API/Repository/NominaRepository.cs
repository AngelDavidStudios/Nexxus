using Amazon.DynamoDBv2.DataModel;
using Nomina.API.Models;
using Nomina.API.Repository.Interfaces;

namespace Nomina.API.Repository;

public class NominaRepository: INominaRepository
{
    private readonly IDynamoDBContext _context;
    
    public NominaRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<NominaItem>> GetAllNominas()
    {
        var conditions = new List<ScanCondition>();
        var allNominas = await _context.ScanAsync<NominaItem>(conditions).GetRemainingAsync();
        return allNominas;
    }
    
    public async Task<NominaItem> GetNominaById(int id)
    {
        return await _context.LoadAsync<NominaItem>(id.ToString());
    }
    
    public async Task<NominaItem> AddNomina(NominaItem nomina)
    {
        nomina.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(nomina);
        return nomina;
    }
    
    public async Task<NominaItem> UpdateNomina(NominaItem nomina)
    {
        await _context.SaveAsync(nomina);
        return nomina;
    }
    
    public async Task<bool> DeleteNomina(int id)
    {
        var nomina = await GetNominaById(id);
        if (nomina == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<NominaItem>(id.ToString());
        return true;
    }
}