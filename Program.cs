using web_05.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IProductRepository, MockProductRepository>();

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
app.Run();
