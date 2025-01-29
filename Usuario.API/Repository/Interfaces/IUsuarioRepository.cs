using Usuario.API.Models;

namespace Usuario.API.Repository.Interfaces;

public interface IUsuarioRepository
{
    Task<IEnumerable<UsuarioItem>> GetAllUsuarios();
    Task<UsuarioItem> GetUsuarioById(int id);
    
    // CRUD
    Task<UsuarioItem> AddUsuario(UsuarioItem usuario);
    Task<UsuarioItem> UpdateUsuario(UsuarioItem usuario);
    Task<bool> DeleteUsuario(int id);
}