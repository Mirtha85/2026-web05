namespace web_05.Models
{
        public class MockCategoryRepository : ICategoryRepository
    {
        
    public IEnumerable<Category> AllCategories =>
    new List<Category>
    {
        new Category
        {
            CategoryId = 1,
            CategoryName = "Anillos y Alianzas",
            Description = "Solitarios eternos, bandas de compromiso y alianzas en oro y platino, diseñadas para momentos inolvidables."
        },
        new Category
        {
            CategoryId = 2,
            CategoryName = "Collares y Colgantes",
            Description = "Cadenas delicadas, perlas luminosas y colgantes con piedras preciosas que realzan el escote con elegancia sutil."
        },
        new Category
        {
            CategoryId = 3,
            CategoryName = "Aros y Pendientes",
            Description = "Aros minimalistas, pendientes de lujo en oro y gemas, desde diseños geométricos hasta piezas statement con brillo eterno."
        },
        new Category
        {
            CategoryId = 4,
            CategoryName = "Brazaletes y Pulseras",
            Description = "Cuff modernos, pulseras infinitas y brazaletes articulados que adornan la muñeca con sofisticación y movimiento."
        },
        new Category
        {
            CategoryId = 5,
            CategoryName = "Accesorios para el Cabello",
            Description = "Horquillas chinas, peinetas florales y adornos elegantes para recogidos, inspirados en la tradición con un toque contemporáneo."
        },
        new Category
        {
            CategoryId = 6,
            CategoryName = "Colección Estacional y Sets",
            Description = "Ediciones limitadas, sets coordinados y piezas especiales para ocasiones únicas y festividades inolvidables."
        }
    };
    }
}