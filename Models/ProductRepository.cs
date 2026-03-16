using Microsoft.EntityFrameworkCore;

namespace web_05.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly JoyeriaDbContext _context;

        public ProductRepository(JoyeriaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> AllProducts => _context.Products.Include(p => p.Category);

        public IEnumerable<Product> FeaturedProducts => _context.Products
            .Include(p => p.Category)
            .Where(p => p.IsFeatured);

        public Product? GetProductById(int productId) => 
            _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == productId);

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            throw new NotImplementedException(); // Puedes implementarlo después
        }
    }
}