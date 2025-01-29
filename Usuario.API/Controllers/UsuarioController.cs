using Microsoft.AspNetCore.Mvc;
using Usuario.API.Models;
using Usuario.API.Repository.Interfaces;

namespace Usuario.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController: ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    
    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<UsuarioItem>> GetAllUsuarios()
    {
        return await _usuarioRepository.GetAllUsuarios();
    }

    [HttpGet("{id}")]
    public async Task<UsuarioItem> GetUsuarioById(int id)
    {
        return await _usuarioRepository.GetUsuarioById(id);
    }
    
    [HttpPost]
    public async Task<UsuarioItem> AddUsuario(UsuarioItem usuario)
    {
        return await _usuarioRepository.AddUsuario(usuario);
    }
    
    [HttpPut]
    public async Task<UsuarioItem> UpdateUsuario(UsuarioItem usuario)
    {
        return await _usuarioRepository.UpdateUsuario(usuario);
    }
    
    [HttpDelete("{id}")]
    public async Task<bool> DeleteUsuario(int id)
    {
        return await _usuarioRepository.DeleteUsuario(id);
    }
}