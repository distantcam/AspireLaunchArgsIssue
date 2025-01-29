Console.WriteLine($"Args: '{string.Join(", ", args)}'");

if (args.Length > 0 && args[0] == "prestart")
{
    // Do prestart logic
    await Task.Delay(10_000);
    return;
}

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGet("/", () => "Hello World!");

app.Run();
