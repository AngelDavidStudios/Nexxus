using Amazon.DynamoDBv2.DataModel;

namespace Empleado.API.Models;

[DynamoDBTable("Empleado")]
public class EmpleadoItem
{
    [DynamoDBHashKey("id")]
    public string? Id { get; set; }
    
    [DynamoDBProperty]
    public string? IdPersona { get; set; }
    
    [DynamoDBProperty]
    public List<DepartamentoItem>? Departamentos { get; set; }
    
    [DynamoDBProperty]
    public List<BancoItem>? EntidadBancaria { get; set; }
    
    [DynamoDBProperty]
    public string? FechaIngreso { get; set; }
    
    [DynamoDBProperty]
    public string? StatusLaboral { get; set; }
}