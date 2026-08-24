var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RecoBOOK_API_Books>("recobook-api-books");

builder.Build().Run();
