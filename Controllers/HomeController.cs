using web_05.Models;
using web_05.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace web_05.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            var FeaturedProducts = _productRepository.FeaturedProducts;

            var homeViewModel = new HomeViewModel(FeaturedProducts);

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
    