using Microsoft.AspNetCore.Mvc;
using web_05.Models;
using web_05.ViewModels;

namespace web_05.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var viewModel = new CategoryListViewModel(
                _categoryRepository.AllCategories,
                "Explora nuestras categorías de joyería"
            );

            return View(viewModel);
        }
    }
}