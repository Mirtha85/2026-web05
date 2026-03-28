using web_05.Models;

namespace web_05.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FeaturedProducts { get; }

        public HomeViewModel(IEnumerable<Product> featuredProducts)
        {
            FeaturedProducts = featuredProducts ?? new List<Product>();
        }
    }
}