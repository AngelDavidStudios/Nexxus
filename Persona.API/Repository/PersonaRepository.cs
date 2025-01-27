using Amazon.DynamoDBv2.DataModel;
using Persona.API.Models;
using Persona.API.Repository.Interfaces;

namespace Persona.API.Repository;

public class PersonaRepository: IPersonaRepository
{
    private readonly IDynamoDBContext _context;
    
    public PersonaRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<PersonaItem>> GetAllPersonas()
    {
        var conditions = new List<ScanCondition>();
        var allPersonas = await _context.ScanAsync<PersonaItem>(conditions).GetRemainingAsync();
        return allPersonas;
    }

    public async Task<PersonaItem> GetPersonaById(int id)
    {
        return await _context.LoadAsync<PersonaItem>(id.ToString());
    }
    
    public async Task<PersonaItem> AddPersona(PersonaItem persona)
    {
        persona.id = Guid.NewGuid().ToString();
        await _context.SaveAsync(persona);
        return persona;
    }
    
    public async Task<PersonaItem> UpdatePersona(PersonaItem persona)
    {
        await _context.SaveAsync(persona);
        return persona;
    }
    
    public async Task<bool> DeletePersona(int id)
    {
        var persona = await GetPersonaById(id);
        if (persona == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<PersonaItem>(id.ToString());
        return true;
    }
}