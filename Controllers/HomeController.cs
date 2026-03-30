using web_05.Models;
using web_05.ViewModels;
using Microsoft.AspNetCore.Mvc;
using web_05.Models;

namespace web_05.Controllers

{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly JoyeriaDbContext _context;     // ← Agregado

        // Constructor modificado
        public HomeController(IProductRepository productRepository, JoyeriaDbContext context)
        {
            _productRepository = productRepository;
            _context = context;                         // ← Inyectamos el DbContext
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

        // GET: Mostrar formulario de registro
        public IActionResult Register()
        {
            return View(new CustomerRegisterViewModel());
        }

        // POST: Guardar el cliente en la base de datos
        [HttpPost]
        public IActionResult Register(CustomerRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer
                {
                    FullName = model.FullName,
                    Phone = model.Phone,
                    Email = model.Email
                };

                _context.Customers.Add(customer);
                _context.SaveChanges();

                TempData["Success"] = "¡Registro exitoso! Gracias por unirte a NAVORI.";
                return RedirectToAction("Register");
            }

            return View(model);
        }
    }
}