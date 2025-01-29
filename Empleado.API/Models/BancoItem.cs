namespace Empleado.API.Models;

public class BancoItem
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string SWIFT { get; set; }
    public string Pais { get; set; }
    public string Sucursal { get; set; }
    public int Telefono { get; set; }
}