using Amazon.DynamoDBv2.DataModel;
using Usuario.API.Models;
using Usuario.API.Repository.Interfaces;

namespace Usuario.API.Repository;

public class UsuarioRepository: IUsuarioRepository
{
    private readonly IDynamoDBContext _context;
    
    public UsuarioRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<UsuarioItem>> GetAllUsuarios()
    {
        var conditions = new List<ScanCondition>();
        var allUsuarios = await _context.ScanAsync<UsuarioItem>(conditions).GetRemainingAsync();
        return allUsuarios;
    }

    public async Task<UsuarioItem> GetUsuarioById(int id)
    {
        return await _context.LoadAsync<UsuarioItem>(id.ToString());
    }
    
    public async Task<UsuarioItem> AddUsuario(UsuarioItem usuario)
    {
        usuario.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(usuario);
        return usuario;
    }
    
    public async Task<UsuarioItem> UpdateUsuario(UsuarioItem usuario)
    {
        await _context.SaveAsync(usuario);
        return usuario;
    }
    
    public async Task<bool> DeleteUsuario(int id)
    {
        var usuario = await GetUsuarioById(id);
        if (usuario == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<UsuarioItem>(id.ToString());
        return true;
    }
}