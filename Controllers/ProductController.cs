using Microsoft.AspNetCore.Mvc;
using web_05.Models;
using web_05.ViewModels;

namespace web_05.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var viewModel = new ProductListViewModel(
                _productRepository.AllProducts, 
                "Todas nuestras joyas"  // Puedes cambiarlo o hacerlo dinámico después
            );

            return View(viewModel);
        }

        // Descomenta y actualiza si quieres la página de detalles
        
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
        
    }
}