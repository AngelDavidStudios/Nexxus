using Amazon.DynamoDBv2.DataModel;

namespace Persona.API.Models;

[DynamoDBTable("Personas")]
public class PersonaItem
{
    [DynamoDBHashKey]
    public string? id { get; set; }
    
    [DynamoDBProperty]
    public string? Dni { get; set; }
    
    [DynamoDBProperty]
    public string? Genero { get; set; }
    
    [DynamoDBProperty]
    public string? Nombre { get; set; }
    
    [DynamoDBProperty]
    public List<int>? Telefono { get; set; }
    
    [DynamoDBProperty]
    public List<string>? Email { get; set; }
    
    [DynamoDBProperty]
    public string? Apellido { get; set; }
    
    [DynamoDBProperty]
    public string? FechaNacimiento { get; set; }
    
    [DynamoDBProperty]
    public List<DireccionItem>? Direccion { get; set; }
}