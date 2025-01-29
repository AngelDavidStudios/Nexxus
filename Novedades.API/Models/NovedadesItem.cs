using Amazon.DynamoDBv2.DataModel;

namespace Novedades.API.Models;

[DynamoDBTable("Novedades")]
public class NovedadesItem
{
    [DynamoDBHashKey("id")]
    public string? Id { get; set; }
    
    [DynamoDBProperty]
    public string? IdRegla { get; set; }
    
    [DynamoDBProperty]
    public string? Fecha { get; set; }
    
    [DynamoDBProperty]
    public string? Tipo { get; set; }
    
    [DynamoDBProperty]
    public string? Monto { get; set; }
    
    [DynamoDBProperty]
    public string? Descripcion { get; set; }
    
    [DynamoDBProperty]
    public string? Status { get; set; }
}