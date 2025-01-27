var builder = DistributedApplication.CreateBuilder(args);

var apiPersona = builder.AddProject<Projects.Persona_API>("persona-api");

builder.Build().Run();