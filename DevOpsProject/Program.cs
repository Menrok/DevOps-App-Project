var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        Application = "DevOps C# Project",
        Status = "Running",
        Environment = app.Environment.EnvironmentName,
        ServerTimeUtc = DateTime.UtcNow
    });
});

app.MapGet("/products", () =>
{
    var products = new[]
    {
        new { Id = 1, Name = "Laptop", Price = 3999.99, InStock = true },
        new { Id = 2, Name = "Mouse", Price = 99.99, InStock = true },
        new { Id = 3, Name = "Keyboard", Price = 199.99, InStock = false }
    };

    return Results.Ok(products);
});

var appEnv = Environment.GetEnvironmentVariable("APP_ENV") ?? "local";
var appVersion = Environment.GetEnvironmentVariable("APP_VERSION") ?? "dev";

app.MapGet("/info", () => new
{
    Environment = appEnv,
    Version = appVersion
});

app.Run();
public partial class Program { }