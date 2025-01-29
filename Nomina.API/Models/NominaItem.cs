using Amazon.DynamoDBv2.DataModel;

namespace Nomina.API.Models;

[DynamoDBTable("Nomina")]
public class NominaItem
{
    [DynamoDBHashKey("id")]
    public string Id { get; set; }
    
    [DynamoDBProperty]
    public string IdEmpleado { get; set; }
    
    [DynamoDBProperty]
    public string IdNovedad { get; set; }
    
    [DynamoDBProperty]
    public string DatePago { get; set; }
    
    [DynamoDBProperty]
    public string SalarioBase { get; set; }
    
    [DynamoDBProperty]
    public string Bonificaciones { get; set; }
    
    [DynamoDBProperty]
    public string Deducciones { get; set; }
    
    [DynamoDBProperty]
    public string SalarioNeto { get; set; }
    
    [DynamoDBProperty]
    public string HorasExtras { get; set; }
    
    [DynamoDBProperty]
    public string Status { get; set; }
}