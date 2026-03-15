using System.ComponentModel.DataAnnotations;  // Opcional, para validaciones futuras

namespace web_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public bool IsFeatured { get; set; }  // Reemplaza IsPieOfTheWeek por algo como "Destacado"
        public int CategoryId { get; set; }
        public Category? Category { get; set; }  // Nullable para evitar warnings
    }
}