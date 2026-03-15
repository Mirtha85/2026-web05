using web_05.Models;

namespace web_05.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> FeaturedProducts { get; }   // antes PiesOfTheWeek
        Product? GetProductById(int productId);
        IEnumerable<Product> SearchProducts(string searchQuery);
    }
}