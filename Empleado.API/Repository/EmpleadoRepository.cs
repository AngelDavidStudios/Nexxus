using Amazon.DynamoDBv2.DataModel;
using Empleado.API.Models;
using Empleado.API.Repository.Interfaces;

namespace Empleado.API.Repository;

public class EmpleadoRepository: IEmpleadoRepository
{
    private readonly IDynamoDBContext _context;
    
    public EmpleadoRepository(IDynamoDBContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<EmpleadoItem>> GetAllEmpleados()
    {
        var conditions = new List<ScanCondition>();
        var allEmpleados = await _context.ScanAsync<EmpleadoItem>(conditions).GetRemainingAsync();
        return allEmpleados;
    }
    
    public async Task<EmpleadoItem> GetEmpleadoById(int id)
    {
        return await _context.LoadAsync<EmpleadoItem>(id.ToString());
    }
    
    public async Task<EmpleadoItem> AddEmpleado(EmpleadoItem empleado)
    {
        empleado.Id = Guid.NewGuid().ToString();
        await _context.SaveAsync(empleado);
        return empleado;
    }
    
    public async Task<EmpleadoItem> UpdateEmpleado(EmpleadoItem empleado)
    {
        await _context.SaveAsync(empleado);
        return empleado;
    }
    
    public async Task<bool> DeleteEmpleado(int id)
    {
        var empleado = await GetEmpleadoById(id);
        if (empleado == null)
        {
            return false;
        }
        
        await _context.DeleteAsync<EmpleadoItem>(id.ToString());
        return true;
    }
}