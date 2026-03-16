using web_05.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Repositorios reales con EF Core
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); // Crea esta clase si no existe
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// Contexto de BD - SQLite (fácil y sin servidor)
builder.Services.AddDbContext<JoyeriaDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("JoyeriaDbConnection")));

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.MapDefaultControllerRoute();
// Redirige la página principal (/) a la lista de productos
app.MapGet("/", () => Results.Redirect("/Product/List"));

// Al final, antes de app.Run()
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<JoyeriaDbContext>();
    db.Database.Migrate();  // Aplica migraciones pendientes automáticamente
    DbInitializer.Seed(app);
}
app.Run();
