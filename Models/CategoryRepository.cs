namespace web_05.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly JoyeriaDbContext _bethanysPieShopDbContext;

        public CategoryRepository(JoyeriaDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}