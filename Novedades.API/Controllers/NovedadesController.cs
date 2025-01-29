using Microsoft.AspNetCore.Mvc;
using Novedades.API.Models;
using Novedades.API.Repository.Interfaces;

namespace Novedades.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NovedadesController: ControllerBase
{
    private readonly INovedadesRepository _novedadesRepository;
    
    public NovedadesController(INovedadesRepository novedadesRepository)
    {
        _novedadesRepository = novedadesRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<NovedadesItem>> GetAllNovedades()
    {
        return await _novedadesRepository.GetAllNovedades();
    }
    
    [HttpGet("{id}")]
    public async Task<NovedadesItem> GetNovedadesById(int id)
    {
        return await _novedadesRepository.GetNovedadesById(id);
    }
    
    [HttpPost]
    public async Task<NovedadesItem> AddNovedades(NovedadesItem novedades)
    {
        return await _novedadesRepository.AddNovedades(novedades);
    }
    
    [HttpPut]
    public async Task<NovedadesItem> UpdateNovedades(NovedadesItem novedades)
    {
        return await _novedadesRepository.UpdateNovedades(novedades);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeleteNovedades(int id)
    {
        return await _novedadesRepository.DeleteNovedades(id);
    }
}