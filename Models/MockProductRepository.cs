using web_05.Models;

namespace web_05.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository;

        public MockProductRepository(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

    public IEnumerable<Product> AllProducts =>
    new List<Product>
    {
        // Categoría 1: Anillos y Alianzas
        new Product {
            ProductId = 1,
            Name = "Anillo Solitario Eterno",
            Price = 2850.00M,
            ShortDescription = "Diamante central en oro blanco 18k, diseño minimalista y eterno.",
            LongDescription = "Una pieza atemporal que captura la luz y el compromiso. Diamante brillante engastado en garras delicadas, perfecto para promesas que duran toda la vida. Incluye certificado GIA.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
            ImageUrl = "/Images/anillodiamanteplata.jpeg",  // ajusta el nombre exacto de tu archivo
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/anillodiamanteplata.jpeg"
        },
        new Product {
            ProductId = 2,
            Name = "Alianza Dorada",
            Price = 980.00M,
            ShortDescription = "Banda en oro amarillo 18k con diamante incrustado, símbolo de unión sin fin.",
            LongDescription = "Diseño fluido y continuo que representa el amor eterno. Acabado pulido con detalles sutiles que brillan con cada movimiento.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
            ImageUrl = "/Images/anillocondiamante.jpeg",
            InStock = true,
            IsFeatured = false,
            ImageThumbnailUrl = "/Images/anillocondiamante.jpeg"
        },

        // Categoría 2: Collares y Colgantes
        new Product {
            ProductId = 3,
            Name = "Collar Perla Luminosa",
            Price = 1200.00M,
            ShortDescription = "Colgante de piedra lunar con un acabado sedoso y un brillo iridiscente que cautiva con cada movimiento.",
            LongDescription = "Perlas de lustre excepcional seleccionadas a mano, anudadas individualmente para elegancia y durabilidad. Ideal para capas o uso solo.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 2),
            ImageUrl = "/Images/collarperla.jpeg",
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/collarperla.jpeg"
        },
        new Product {
            ProductId = 4,
            Name = "Colgante Corazón Blanco",
            Price = 750.00M,
            ShortDescription = "Corazón delicado en oro con piedra central.",
            LongDescription = "Un colgante romántico y sutil que captura la luz con gracia. Perfecto como regalo o pieza personal.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 2),
            ImageUrl = "/Images/collarcorazonblanco.jpeg",
            InStock = true,
            IsFeatured = false,
            ImageThumbnailUrl = "/Images/collarcorazonblanco.jpeg"
        },

        // Categoría 3: Aros y Pendientes
        new Product {
            ProductId = 5,
            Name = "Aros Hoops Dorados Clásicos",
            Price = 650.00M,
            ShortDescription = "Aros circulares en oro 18k, diseño limpio y versátil.",
            LongDescription = "Elegancia cotidiana con un toque de brillo sutil. Perfectos para uso diario o para elevar cualquier look.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 3),
            ImageUrl = "/Images/arosc.jpeg",
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/arosc.jpeg"
        },
        new Product {
            ProductId = 6,
            Name = "Pendientes Perla y Oro",
            Price = 890.00M,
            ShortDescription = "Perlas delicadas con detalles en oro amarillo.",
            LongDescription = "Clásico reinventado: perlas suaves suspendidas en oro pulido, ideales para eventos o uso sofisticado diario.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 3),
            ImageUrl = "/Images/argollasperla.jpeg",
            InStock = true,
            IsFeatured = false,
            ImageThumbnailUrl = "/Images/argollasperla.jpeg"
        },

        // Categoría 4: Brazaletes y Pulseras
        new Product {
            ProductId = 7,
            Name = "Brazalete Cuff Infinito",
            Price = 1800.00M,
            ShortDescription = "Cuff abierto en oro con diseño infinito.",
            LongDescription = "Una pieza statement que abraza la muñeca con fluidez y poder. Acabado satinado para un brillo discreto.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 4),
            ImageUrl = "/Images/brazaleteinfinito.jpeg",
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/brazaleteinfinito.jpeg"
        },
        new Product {
            ProductId = 8,
            Name = "Pulsera Cadena Dorada",
            Price = 950.00M,
            ShortDescription = "Cadena con eslabones entrelazados en oro.",
            LongDescription = "Ligera y versátil, perfecta para stacking o uso solo. Brillo eterno con cierre de seguridad.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 4),
            ImageUrl = "/Images/cadena.jpeg",
            InStock = true,
            IsFeatured = false,
            ImageThumbnailUrl = "/Images/cadena.jpeg"
        },

        // Categoría 5: Accesorios para el Cabello
        new Product {
            ProductId = 9,
            Name = "Horquilla China Flor Jade",
            Price = 480.00M,
            ShortDescription = "Horquilla tradicional con flor de jade y perla.",
            LongDescription = "Inspirada en la elegancia oriental: jade verde tallado con perla central, ideal para recogidos sofisticados.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 5),
            ImageUrl = "/Images/horquillaazul.jpeg",
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/horquillaazul.jpeg"
        },
        new Product {
            ProductId = 10,
            Name = "Peineta Jade Minimal",
            Price = 620.00M,
            ShortDescription = "Peineta delicada con Flor de Jade y detalles dorados.",
            LongDescription = "Adorno sutil para moños y trenzas, combina tradición y modernidad con detalles de jade y oro.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 5),
            ImageUrl = "/Images/peinetaflores.jpeg",
            InStock = true,
            IsFeatured = false,
            ImageThumbnailUrl = "/Images/peinetaflores.jpeg"
        },

        // Categoría 6: Colección Estacional y Sets
        new Product {
            ProductId = 11,
            Name = "Set Esmeraldas y Oro",
            Price = 3200.00M,
            ShortDescription = "Conjunto de pendientes y collar con esmeraldas naturales.",
            LongDescription = "Edición limitada: esmeraldas intensas engastadas en oro rosa, para momentos especiales y brillantes.",
            Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 6),
            ImageUrl = "/Images/setesmeraldas.jpeg",
            InStock = true,
            IsFeatured = true,
            ImageThumbnailUrl = "/Images/setesmeraldas.jpeg"
        },


        // 1. Gargantilla de Diamantes
new Product {
    ProductId = 12,
    Name = "Gargantilla Constelación",
    Price = 5400.00M,
    ShortDescription = "Lluvia de diamantes corte brillante en platino.",
    LongDescription = "Una pieza de alta joyería que emula el brillo de las estrellas. Cada diamante ha sido seleccionado por su pureza excepcional, creando un efecto de luz continua sobre la piel.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 2),
    ImageUrl = "/Images/gargantilla.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/gargantilla.jpeg"
},

// 2. Anillo de Zafiro
new Product {
    ProductId = 13,
    Name = "Anillo Royal Azure",
    Price = 4100.00M,
    ShortDescription = "Zafiro de Ceilán rodeado de un halo de brillantes.",
    LongDescription = "La profundidad del azul real se encuentra con la claridad del oro  de 18k. Una sortija diseñada para heredar, con un zafiro central de corte ovalado.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
    ImageUrl = "/Images/anillocorazon.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/anilloazul.jpeg"
},

// 3. Reloj de Lujo
new Product {
    ProductId = 14,
    Name = "Set Oro Rosa",
    Price = 8500.00M,
    ShortDescription = "Conjunto de joyas en oro rosa con detalles de diamantes.",
    LongDescription = "Un set completo que incluye collar, pendientes y brazalete, todos en oro rosa de 18k con diamantes incrustados. Perfecto para ocasiones especiales o para elevar el estilo diario con un toque de lujo.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 6),
    ImageUrl = "/Images/setrosado.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/setrosado.jpeg"
},

// 4. Pendientes de Rubí
new Product {
    ProductId = 15,
    Name = "Set Gota de Fuego",
    Price = 2850.00M,
    ShortDescription = "Conjunto de pendientes de oro dorado con incrustaciones de rubíes.",
    LongDescription = "Símbolo de pasión y fuerza. Estos rubíes de corte pera bailan con el movimiento, capturando destellos carmesí que iluminan el rostro.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 6),
    ImageUrl = "/Images/setgotacondiamantes4.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/setgotacondiamantes4.jpeg"
},

// 5. Brazalete Rígido
new Product {
    ProductId = 16,
    Name = "Brazalete Jade",
    Price = 1200.00M,
    ShortDescription = "Brazalete de jade verde con detalles de oro.",
    LongDescription = "Para la mujer que busca un lujo diferente. El acabado en rodio verde resalta el misterio de los diamantes oscuros en una estructura rígida y minimalista.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 4),
    ImageUrl = "/Images/brazaletejade10.jpg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/brazaletejade10.jpg"
},

// 6. Broche Art Deco
new Product {
    ProductId = 17,
    Name = "Broche Vintage",
    Price = 1800.00M,
    ShortDescription = "Broche de estilo Art Deco con detalles de ónix y diamantes.",
    LongDescription = "Incrustaciones de ónix y diamantes sobre una base de plata de ley. Una pieza de colección que aporta un aire aristocrático a cualquier prenda.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 5),
    ImageUrl = "/Images/peinetaplata.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/peinetaplata.jpeg"
},

// 7. Collar de Perlas
new Product {
    ProductId = 18,
    Name = "Set Perlas del Sur",
    Price = 3600.00M,
    ShortDescription = "Set de perlas de los Mares del Sur con broche de oro.",
    LongDescription = "Perlas seleccionadas por su oriente y redondez perfecta. La joya más clásica del mundo, reinventada con un cierre moderno de seguridad en oro de 18k.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 6),
    ImageUrl = "/Images/setperlas.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/setperlas.jpeg"
},

// 8. Anillo de Compromiso Moderno
new Product {
    ProductId = 19,
    Name = "Solitario Prisma",
    Price = 2200.00M,
    ShortDescription = "Diamante corte princesa en una montura arquitectónica.",
    LongDescription = "Líneas rectas y ángulos perfectos. Este anillo representa la modernidad del amor actual, con un engaste que permite ver el diamante en toda su magnitud.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
    ImageUrl = "/Images/anillodeplata.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/anillodeplata.jpeg"
},

// 9. Tobillera de Lujo
new Product {
    ProductId = 20,
    Name = "Aretes Verano Aura",
    Price = 750.00M,
    ShortDescription = "Aros en forma de almeja con perlas para el verano .",
    LongDescription = "En verano, estos aros de almeja con perlas son la elección perfecta para un look fresco y elegante.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 3),
    ImageUrl = "/Images/arosalmeja.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/arosalmeja.jpeg"
},

// 10. Gemelos para Caballero
new Product {
    ProductId = 21,
    Name = "Anillo Corazon de Zafiro",
    Price = 950.00M,
    ShortDescription = "Anillo de oro blanco con zafiro azul en forma de corazón.",
    LongDescription = "Un anillo elegante y romántico, con un zafiro azul de alta calidad en forma de corazón. Diseñado para quienes buscan un toque clásico y sofisticado.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
    ImageUrl = "/Images/anillocorazon.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/anillocorazon.jpeg"
},

// 1. ANILLO (CategoryId = 1)
new Product {
    ProductId = 22,
    Name = "Anillo Ópalo de Fuego",
    Price = 1850.00M,
    ShortDescription = "Ópalo central con destellos iridiscentes en oro rosa.",
    LongDescription = "Una gema mística que cambia de color con la luz. Este ópalo está flanqueado por diamantes minúsculos que realzan su fuego interno.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
    ImageUrl = "/Images/anillopromesa.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/anillopromesa.jpeg"
},

// 2. COLLAR (CategoryId = 2)
new Product {
    ProductId = 23,
    Name = "Colgante Medallón Solar",
    Price = 920.00M,
    ShortDescription = "Medallón de oro de 18k con grabado artesanal.",
    LongDescription = "Inspirado en los amuletos antiguos, este medallón presenta un sol radiante con un pequeño rubí en el centro. Una pieza con alma y elegancia.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 2),
    ImageUrl = "/Images/dije.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/dije.jpeg"
},

// 3. AROS (CategoryId = 3)
new Product {
    ProductId = 24,
    Name = "Aros Espiral Infinito",
    Price = 480.00M,
    ShortDescription = "Diseño de espiral fluida en plata de ley bañada en oro.",
    LongDescription = "La geometría se vuelve orgánica en estos aros de diseño continuo. Su forma tridimensional crea un juego de sombras y luces muy vanguardista.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 3),
    ImageUrl = "/Images/aroschonki.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/aroschonki.jpeg"
},

// 4. BRAZALETES (CategoryId = 4)
new Product {
    ProductId = 25,
    Name = "Brazalete Rígido 'Cuff' Esculpido",
    Price = 1350.00M,
    ShortDescription = "Estructura de oro sólido con textura martillada a mano.",
    LongDescription = "Cada pieza es única. La textura martillada refleja la luz de forma irregular, dando un aspecto rústico pero extremadamente lujoso a la muñeca.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 4),
    ImageUrl = "/Images/argolla.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/argolla.jpeg"
},

// 5. ACCESORIOS CABELLO (CategoryId = 5)
new Product {
    ProductId = 26,
    Name = "Horquilla Perla Regia",
    Price = 210.00M,
    ShortDescription = "Pasador de plata con perlas barroca de diferente tamaño.",
    LongDescription = "El accesorio perfecto para novias o eventos de gala. La irregularidad de la perla barroca aporta un toque de distinción natural y elegante.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 5),
    ImageUrl = "/Images/horquillaplata.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/horquillaplata.jpeg"
},

// 6. SET (CategoryId = 6)
new Product {
    ProductId = 27,
    Name = "Dúo Nocturno Anastasia",
    Price = 2950.00M,
    ShortDescription = "Conjunto de gargantilla y sortija con aros.",
    LongDescription = "La nobleza de la plata en su máxima expresión. Un conjunto de noche inolvidable, simple y elegante.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 6),
    ImageUrl = "/Images/setsimple.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/setsimple.jpeg"
},

// 7. ANILLO (CategoryId = 1)
new Product {
    ProductId = 28,
    Name = "Argolla Sello Natural",
    Price = 1100.00M,
    ShortDescription = "una argolla pensada en la simplicidad y majestuosidad de la naturaleza.",
    LongDescription = "La naturaleza se manifiesta en esta argolla con una forma minimalista y elegante. Su diseño sencillo resalta la belleza natural del material.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 1),
    ImageUrl = "/Images/anillonaturaleza.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/anillonaturaleza.jpeg"
},

// 8. COLLAR (CategoryId = 2)
new Product {
    ProductId = 29,
    Name = "Colgante eclipse negro ",
    Price = 1600.00M,
    ShortDescription = "Collar de oro con dije negro que inspira elegancia y misterio.",
    LongDescription = "Un dije de diseño moderno y elegante, con una forma que combina la sofisticación de la joyería clásica con un toque contemporáneo.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 2),
    ImageUrl = "/Images/colgantecondijenegro.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/colgantecondijenegro.jpeg"
},

// 9. AROS (CategoryId = 3)
new Product {
    ProductId = 30,
    Name = "Pendientes Cascada de Estrellas",
    Price = 640.00M,
    ShortDescription = "Largas tiras de diamantes que caen con ligereza.",
    LongDescription = "Diseñados para captar el movimiento. Estos pendientes largos crean un efecto de cascada brillante que estiliza el cuello y aporta luz intensa.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 3),
    ImageUrl = "/Images/aroshoja.jpeg",
    InStock = true,
    IsFeatured = false,
    ImageThumbnailUrl = "/Images/aroshoja.jpeg"
},

// 10. ACCESORIOS CABELLO (CategoryId = 5)
new Product {
    ProductId = 31,
    Name = "Horquilla Oriental de Rubí",
    Price = 1250.00M,
    ShortDescription = "Horquilla de estilo oriental con rubíes incrustados.",
    LongDescription = "Una horquilla elegante de estilo oriental, con rubíes incrustados que aportan un toque de lujo y sofisticación.",
    Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == 5),
    ImageUrl = "/Images/horquillarubi.jpeg",
    InStock = true,
    IsFeatured = true,
    ImageThumbnailUrl = "/Images/horquillarubi.jpeg"
}
        // Agrega más siguiendo el patrón (ej: setgotacondiama, setminimalista5, etc.)
    };

        public IEnumerable<Product> FeaturedProducts => AllProducts.Where(p => p.IsFeatured);

        public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            throw new NotImplementedException();  // Implementa después si quieres búsqueda
        }
    }
}