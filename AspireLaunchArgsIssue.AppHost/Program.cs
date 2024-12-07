var builder = DistributedApplication.CreateBuilder(args);

var prestart = builder
    .AddProject<Projects.AspireLaunchArgsIssue>("prestart", launchProfileName: "prestart");

builder.AddProject<Projects.AspireLaunchArgsIssue>("aspirelaunchargsissue")
    .WaitForCompletion(prestart);

builder.Build().Run();
