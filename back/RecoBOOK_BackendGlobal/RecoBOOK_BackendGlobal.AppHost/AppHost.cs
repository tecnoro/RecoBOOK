var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.API_Books>("recobook-api-books", launchProfileName: "https");

builder.Build().Run();
