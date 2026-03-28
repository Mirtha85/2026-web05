using web_05.Models;
using web_05.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace web_05.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, IShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToCart(int productId)
        {
            var product = _productRepository.GetProductById(productId);

            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int productId)
        {
            var product = _productRepository.GetProductById(productId);

            if (product != null)
            {
                _shoppingCart.RemoveFromCart(product);
            }

            return RedirectToAction("Index");
        }
    }
}