using Amazon.DynamoDBv2.DataModel;

namespace Parametros.API.Models;

[DynamoDBTable("Parametros")]
public class ParametroItem
{
    [DynamoDBHashKey("id")]
    public string Id { get; set; }
    
    [DynamoDBProperty]
    public string Tipo { get; set; }
    
    [DynamoDBProperty]
    public string SubTipo { get; set; }
    
    [DynamoDBProperty]
    public string Descripcion { get; set; }
    
    [DynamoDBProperty]
    public string Activo { get; set; }
    
    [DynamoDBProperty]
    public string Porcentaje { get; set; }
    
    [DynamoDBProperty]
    public string DateCreated { get; set; }
}