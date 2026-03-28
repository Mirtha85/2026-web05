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

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configuración del pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto: ahora apunta a Home/Index (la página principal con carousel)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Redirigir la raíz "/" a Home/Index (por si acaso alguien entra sin controlador)
app.MapGet("/", () => Results.Redirect("/Home/Index"));

// Aplicar migraciones + seed antes de servir la app
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<JoyeriaDbContext>();

    // 1. Aplicar migraciones (crea tablas si no existen)
    db.Database.Migrate();

    // 2. Sembrar datos
    DbInitializer.Seed(app);
}

app.Run();