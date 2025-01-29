using Microsoft.AspNetCore.Mvc;
using Persona.API.Models;
using Persona.API.Repository.Interfaces;

namespace Persona.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonaController: ControllerBase
{
    private readonly IPersonaRepository _personaRepository;
    
    public PersonaController(IPersonaRepository personaRepository)
    {
        _personaRepository = personaRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<PersonaItem>> GetAllPersonas()
    {
        return await _personaRepository.GetAllPersonas();
    }

    [HttpGet("{id}")]
    public async Task<PersonaItem> GetPersonaById(int id)
    {
        return await _personaRepository.GetPersonaById(id);
    }
    
    [HttpPost]
    public async Task<PersonaItem> AddPersona(PersonaItem persona)
    {
        return await _personaRepository.AddPersona(persona);
    }
    
    [HttpPut]
    public async Task<PersonaItem> UpdatePersona(PersonaItem persona)
    {
        return await _personaRepository.UpdatePersona(persona);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeletePersona(int id)
    {
        return await _personaRepository.DeletePersona(id);
    }
}