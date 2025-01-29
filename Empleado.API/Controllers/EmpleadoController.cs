using Empleado.API.Models;
using Empleado.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Empleado.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmpleadoController: ControllerBase
{
    private readonly IEmpleadoRepository _empleadoRepository;
    
    public EmpleadoController(IEmpleadoRepository empleadoRepository)
    {
        _empleadoRepository = empleadoRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<EmpleadoItem>> GetAllEmpleados()
    {
        return await _empleadoRepository.GetAllEmpleados();
    }
    
    [HttpGet("{id}")]
    public async Task<EmpleadoItem> GetEmpleadoById(int id)
    {
        return await _empleadoRepository.GetEmpleadoById(id);
    }
    
    [HttpPost]
    public async Task<EmpleadoItem> AddEmpleado(EmpleadoItem empleado)
    {
        return await _empleadoRepository.AddEmpleado(empleado);
    }
    
    [HttpPut]
    public async Task<EmpleadoItem> UpdateEmpleado(EmpleadoItem empleado)
    {
        return await _empleadoRepository.UpdateEmpleado(empleado);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeleteEmpleado(int id)
    {
        return await _empleadoRepository.DeleteEmpleado(id);
    }
}