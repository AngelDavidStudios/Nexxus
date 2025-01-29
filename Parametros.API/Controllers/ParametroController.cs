using Microsoft.AspNetCore.Mvc;
using Parametros.API.Models;
using Parametros.API.Repository.Interfaces;

namespace Parametros.API.Controllers;

[Route("api/[controller]")]
[ApiController] 
public class ParametroController: ControllerBase
{
    private readonly IParametroInterface _parametroInterface;
    
    public ParametroController(IParametroInterface parametroInterface)
    {
        _parametroInterface = parametroInterface;
    }
    
    [HttpGet]
    public async Task<IEnumerable<ParametroItem>> GetAllParametros()
    {
        return await _parametroInterface.GetAllParametros();
    }
    
    [HttpGet("{id}")]
    public async Task<ParametroItem> GetParametroById(int id)
    {
        return await _parametroInterface.GetParametroById(id);
    }
    
    [HttpPost]
    public async Task<ParametroItem> AddParametro(ParametroItem parametro)
    {
        return await _parametroInterface.AddParametro(parametro);
    }
    
    [HttpPut]
    public async Task<ParametroItem> UpdateParametro(ParametroItem parametro)
    {
        return await _parametroInterface.UpdateParametro(parametro);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeleteParametro(int id)
    {
        return await _parametroInterface.DeleteParametro(id);
    }
}