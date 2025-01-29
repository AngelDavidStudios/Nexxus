using Microsoft.AspNetCore.Mvc;
using Nomina.API.Models;
using Nomina.API.Repository.Interfaces;

namespace Nomina.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NominaController: ControllerBase
{
    private readonly INominaRepository _nominaRepository;
    
    public NominaController(INominaRepository nominaRepository)
    {
        _nominaRepository = nominaRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<NominaItem>> GetAllNominas()
    {
        return await _nominaRepository.GetAllNominas();
    }

    [HttpGet("{id}")]
    public async Task<NominaItem> GetNominaById(int id)
    {
        return await _nominaRepository.GetNominaById(id);
    }
    
    [HttpPost]
    public async Task<NominaItem> AddNomina(NominaItem nomina)
    {
        return await _nominaRepository.AddNomina(nomina);
    }
    
    [HttpPut]
    public async Task<NominaItem> UpdateNomina(NominaItem nomina)
    {
        return await _nominaRepository.UpdateNomina(nomina);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeleteNomina(int id)
    {
        return await _nominaRepository.DeleteNomina(id);
    }
}