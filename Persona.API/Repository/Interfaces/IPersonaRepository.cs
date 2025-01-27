using Persona.API.Models;
namespace Persona.API.Repository.Interfaces;

public interface IPersonaRepository
{
    Task<IEnumerable<PersonaItem>> GetAllPersonas();
    Task<PersonaItem> GetPersonaById(int id);
    
    // CRUD
    Task<PersonaItem> AddPersona(PersonaItem persona);
    Task<PersonaItem> UpdatePersona(PersonaItem persona);
    Task<bool> DeletePersona(int id);
}