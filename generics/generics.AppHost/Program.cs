var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.generics>("generics");

builder.Build().Run();
