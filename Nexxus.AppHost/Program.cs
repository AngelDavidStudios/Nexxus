using Amazon;

var builder = DistributedApplication.CreateBuilder(args);

// AWS .NET SDK configuration
var awsConfig = builder.AddAWSSDKConfig()
                        .WithProfile("AdminAccess")
                        .WithRegion(RegionEndpoint.USEast1);

var apiPersona = builder.AddProject<Projects.Persona_API>("persona-api");
var apiUsuario = builder.AddProject<Projects.Usuario_API>("usuario-api");
var apiEmpleado = builder.AddProject<Projects.Empleado_API>("empleado-api");

builder.Build().Run();