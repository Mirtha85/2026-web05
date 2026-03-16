using Microsoft.EntityFrameworkCore;

namespace web_05.Models
{
    public class JoyeriaDbContext : DbContext
    {
        public JoyeriaDbContext(DbContextOptions<JoyeriaDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }     // ¡Cambia Pies por Products!
        public DbSet<Category> Categories { get; set; }
    }
}