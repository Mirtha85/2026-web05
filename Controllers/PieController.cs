using Microsoft.AspNetCore.Mvc;
using web_05.Models;
namespace web_05.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes";
            return View(_pieRepository.AllPies);
        }
    }
}