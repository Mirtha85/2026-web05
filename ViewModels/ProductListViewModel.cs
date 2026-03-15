using web_05.Models;

namespace web_05.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; }
        public string? CurrentCategory { get; }

        public ProductListViewModel(IEnumerable<Product> products, string? currentCategory)
        {
            Products = products;
            CurrentCategory = currentCategory;
        }
    }
}