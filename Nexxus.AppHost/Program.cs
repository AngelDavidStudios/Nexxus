using Amazon;

var builder = DistributedApplication.CreateBuilder(args);

// AWS .NET SDK configuration
var awsConfig = builder.AddAWSSDKConfig()
                        .WithProfile("AdminAccess")
                        .WithRegion(RegionEndpoint.USEast1);

// API projects
var apiPersona = builder.AddProject<Projects.Persona_API>("persona-api");
var apiUsuario = builder.AddProject<Projects.Usuario_API>("usuario-api");
var apiEmpleado = builder.AddProject<Projects.Empleado_API>("empleado-api");
var apiParametro = builder.AddProject<Projects.Parametros_API>("parametro-api");
var apiNovedades = builder.AddProject<Projects.Novedades_API>("novedades-api");
var apiNomina = builder.AddProject<Projects.Nomina_API>("nomina-api");

builder.Build().Run();