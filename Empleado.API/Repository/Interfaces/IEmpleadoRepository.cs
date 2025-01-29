using Empleado.API.Models;

namespace Empleado.API.Repository.Interfaces;

public interface IEmpleadoRepository
{
    Task<IEnumerable<EmpleadoItem>> GetAllEmpleados();
    Task<EmpleadoItem> GetEmpleadoById(int id);
    
    // CRUD
    Task<EmpleadoItem> AddEmpleado(EmpleadoItem empleado);
    Task<EmpleadoItem> UpdateEmpleado(EmpleadoItem empleado);
    Task<bool> DeleteEmpleado(int id);
}