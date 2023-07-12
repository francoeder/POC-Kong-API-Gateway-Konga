var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { Service = "Service B1" });

app.Run();
