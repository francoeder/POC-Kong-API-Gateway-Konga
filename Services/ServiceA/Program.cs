var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { Service = "Service A" });

app.Run();
