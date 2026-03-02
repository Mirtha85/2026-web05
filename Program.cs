var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "BIENVENIDOS AL TERRITORIO DE ALIZON");

app.Run();
