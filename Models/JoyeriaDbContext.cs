using web_05.Models;
using Microsoft.EntityFrameworkCore;
using web_05.Models;        // Asegúrate que este namespace sea correcto

namespace web_05.Models
{
    public class JoyeriaDbContext : DbContext
    {
        public JoyeriaDbContext(DbContextOptions<JoyeriaDbContext> options) : base(options)
        {
        }

        // Aquí van todas las tablas de tu base de datos
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // Opcional: Puedes configurar relaciones o nombres de tablas aquí si quieres
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ejemplo: Configurar que el Email sea único (opcional pero recomendado)
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}