using web_05.Models;
using System.Collections.Generic;

namespace web_05.ViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories { get; }
        public string? Title { get; }           // Título de la página o sección
        public int TotalCategories { get; }     // Ejemplo de dato extra útil

        public CategoryListViewModel(
            IEnumerable<Category> categories,
            string? title = "Todas las Categorías")
        {
            Categories = categories ?? new List<Category>();
            Title = title;
            TotalCategories = Categories.Count();
        }
    }
}