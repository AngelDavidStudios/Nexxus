using Amazon.DynamoDBv2.DataModel;

namespace Usuario.API.Models;

[DynamoDBTable("Usuarios")]
public class UsuarioItem
{
    [DynamoDBHashKey("id")]
    public string? Id { get; set; }
    
    [DynamoDBProperty]
    public string? IdPersona { get; set; }
    
    [DynamoDBProperty]
    public string? Username { get; set; }
    
    [DynamoDBProperty]
    public string? Password { get; set; }
    
    [DynamoDBProperty]
    public string? Rol { get; set; }
    
    [DynamoDBProperty]
    public string? LastLogin { get; set; }
    
    [DynamoDBProperty]
    public string? Status { get; set; }
    
    [DynamoDBProperty]
    public string? DateCreated { get; set; }
}