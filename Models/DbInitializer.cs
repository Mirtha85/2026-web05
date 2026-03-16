using Microsoft.EntityFrameworkCore;

namespace web_05.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<JoyeriaDbContext>();

            // 1. Seed de categorías (si no existen)
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryId = 1, CategoryName = "Anillos y Alianzas", Description = "Solitarios eternos, bandas de compromiso y alianzas en oro y platino, diseñadas para momentos inolvidables." },
                    new Category { CategoryId = 2, CategoryName = "Collares y Colgantes", Description = "Cadenas delicadas, perlas luminosas y colgantes con piedras preciosas que realzan el escote con elegancia sutil." },
                    new Category { CategoryId = 3, CategoryName = "Aros y Pendientes", Description = "Aros minimalistas, pendientes de lujo en oro y gemas, desde diseños geométricos hasta piezas statement con brillo eterno." },
                    new Category { CategoryId = 4, CategoryName = "Brazaletes y Pulseras", Description = "Cuff modernos, pulseras infinitas y brazaletes articulados que adornan la muñeca con sofisticación y movimiento." },
                    new Category { CategoryId = 5, CategoryName = "Accesorios para el Cabello", Description = "Horquillas chinas, peinetas florales y adornos elegantes para recogidos, inspirados en la tradición con un toque contemporáneo." },
                    new Category { CategoryId = 6, CategoryName = "Colección Estacional y Sets", Description = "Ediciones limitadas, sets coordinados y piezas especiales para ocasiones únicas y festividades inolvidables." }
                );
                context.SaveChanges();
            }

            // 2. Seed de productos (solo si no hay ninguno)
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    // Categoría 1: Anillos y Alianzas
                    new Product { ProductId = 1, Name = "Anillo Solitario Eterno", Price = 2850.00M, ShortDescription = "Diamante central en oro blanco 18k, diseño minimalista y eterno.", LongDescription = "Una pieza atemporal que captura la luz y el compromiso. Diamante brillante engastado en garras delicadas, perfecto para promesas que duran toda la vida. Incluye certificado GIA.", CategoryId = 1, ImageUrl = "/Images/anillodiamanteplata.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 2, Name = "Alianza Dorada", Price = 980.00M, ShortDescription = "Banda en oro amarillo 18k con diamante incrustado, símbolo de unión sin fin.", LongDescription = "Diseño fluido y continuo que representa el amor eterno. Acabado pulido con detalles sutiles que brillan con cada movimiento.", CategoryId = 1, ImageUrl = "/Images/anillocondiamante.jpeg", InStock = true, IsFeatured = false },

                    // Categoría 2: Collares y Colgantes
                    new Product { ProductId = 3, Name = "Collar Perla Luminosa", Price = 1200.00M, ShortDescription = "Colgante de piedra lunar con un acabado sedoso y un brillo iridiscente.", LongDescription = "Perlas de lustre excepcional seleccionadas a mano, anudadas individualmente para elegancia y durabilidad.", CategoryId = 2, ImageUrl = "/Images/collarperla.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 4, Name = "Colgante Corazón Blanco", Price = 750.00M, ShortDescription = "Corazón delicado en oro con piedra central.", LongDescription = "Un colgante romántico y sutil que captura la luz con gracia.", CategoryId = 2, ImageUrl = "/Images/colgarcorazonblanco.jpeg", InStock = true, IsFeatured = false },

                    // Categoría 3: Aros y Pendientes
                    new Product { ProductId = 5, Name = "Aros Hoops Dorados Clásicos", Price = 650.00M, ShortDescription = "Aros circulares en oro 18k, diseño limpio y versátil.", LongDescription = "Elegancia cotidiana con un toque de brillo sutil.", CategoryId = 3, ImageUrl = "/Images/arosc.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 6, Name = "Pendientes Perla y Oro", Price = 890.00M, ShortDescription = "Perlas delicadas con detalles en oro amarillo.", LongDescription = "Clásico reinventado: perlas suaves suspendidas en oro pulido.", CategoryId = 3, ImageUrl = "/Images/argollasperla.jpeg", InStock = true, IsFeatured = false },

                    // Categoría 4: Brazaletes y Pulseras
                    new Product { ProductId = 7, Name = "Brazalete Cuff Infinito", Price = 1800.00M, ShortDescription = "Cuff abierto en oro con diseño infinito.", LongDescription = "Una pieza statement que abraza la muñeca con fluidez y poder.", CategoryId = 4, ImageUrl = "/Images/brazaleteinfinito.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 8, Name = "Pulsera Cadena Dorada", Price = 950.00M, ShortDescription = "Cadena con eslabones entrelazados en oro.", LongDescription = "Ligera y versátil, perfecta para stacking o uso solo.", CategoryId = 4, ImageUrl = "/Images/cadena.jpeg", InStock = true, IsFeatured = false },

                    // Categoría 5: Accesorios para el Cabello
                    new Product { ProductId = 9, Name = "Horquilla China Flor Jade", Price = 480.00M, ShortDescription = "Horquilla tradicional con flor de jade y perla.", LongDescription = "Inspirada en la elegancia oriental: jade verde tallado con perla central.", CategoryId = 5, ImageUrl = "/Images/horquillaazul.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 10, Name = "Peineta Jade Minimal", Price = 620.00M, ShortDescription = "Peineta delicada con Flor de Jade y detalles dorados.", LongDescription = "Adorno sutil para moños y trenzas.", CategoryId = 5, ImageUrl = "/Images/peinetaflores.jpeg", InStock = true, IsFeatured = false },

                    // Categoría 6: Sets y Colección Estacional
                    new Product { ProductId = 11, Name = "Set Esmeraldas y Oro", Price = 3200.00M, ShortDescription = "Conjunto de pendientes y collar con esmeraldas naturales.", LongDescription = "Edición limitada: esmeraldas intensas engastadas en oro rosa.", CategoryId = 6, ImageUrl = "/Images/setesmeraldas.jpeg", InStock = true, IsFeatured = true },

                    // Tus productos adicionales (adaptados)
                    new Product { ProductId = 12, Name = "Gargantilla Constelación", Price = 5400.00M, ShortDescription = "Lluvia de diamantes corte brillante en platino.", LongDescription = "Cada diamante ha sido seleccionado por su pureza excepcional.", CategoryId = 2, ImageUrl = "/Images/gargantilla.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 13, Name = "Anillo Royal Azure", Price = 4100.00M, ShortDescription = "Zafiro de Ceilán rodeado de un halo de brillantes.", LongDescription = "La profundidad del azul real se encuentra con la claridad del oro.", CategoryId = 1, ImageUrl = "/Images/anillocorazon.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 14, Name = "Set Oro Rosa", Price = 8500.00M, ShortDescription = "Conjunto de joyas en oro rosa con detalles de diamantes.", LongDescription = "Un set completo para ocasiones especiales.", CategoryId = 6, ImageUrl = "/Images/setrosado.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 15, Name = "Set Gota de Fuego", Price = 2850.00M, ShortDescription = "Conjunto de pendientes de oro dorado con rubíes.", LongDescription = "Símbolo de pasión y fuerza.", CategoryId = 6, ImageUrl = "/Images/setgotacondiamantes4.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 16, Name = "Brazalete Jade", Price = 1200.00M, ShortDescription = "Brazalete de jade verde con detalles de oro.", LongDescription = "Para la mujer que busca un lujo diferente.", CategoryId = 4, ImageUrl = "/Images/brazaletejade10.jpg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 17, Name = "Broche Vintage", Price = 1800.00M, ShortDescription = "Broche de estilo Art Deco con ónix y diamantes.", LongDescription = "Una pieza de colección aristocrática.", CategoryId = 5, ImageUrl = "/Images/peinetaplata.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 18, Name = "Set Perlas del Sur", Price = 3600.00M, ShortDescription = "Set de perlas de los Mares del Sur con broche de oro.", LongDescription = "Perlas seleccionadas por su oriente perfecto.", CategoryId = 6, ImageUrl = "/Images/setperlas.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 19, Name = "Solitario Prisma", Price = 2200.00M, ShortDescription = "Diamante corte princesa en montura arquitectónica.", LongDescription = "Líneas rectas y ángulos perfectos.", CategoryId = 1, ImageUrl = "/Images/anillodeplata.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 20, Name = "Aretes Verano Aura", Price = 750.00M, ShortDescription = "Aros en forma de almeja con perlas.", LongDescription = "Perfectos para un look fresco y elegante.", CategoryId = 3, ImageUrl = "/Images/arosalmeja.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 21, Name = "Anillo Corazón de Zafiro", Price = 950.00M, ShortDescription = "Anillo de oro blanco con zafiro azul en forma de corazón.", LongDescription = "Elegante y romántico.", CategoryId = 1, ImageUrl = "/Images/anillocorazon.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 22, Name = "Anillo Ópalo de Fuego", Price = 1850.00M, ShortDescription = "Ópalo central con destellos iridiscentes en oro rosa.", LongDescription = "Una gema mística que cambia de color con la luz.", CategoryId = 1, ImageUrl = "/Images/anillopromesa.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 23, Name = "Colgante Medallón Solar", Price = 920.00M, ShortDescription = "Medallón de oro de 18k con grabado artesanal.", LongDescription = "Inspirado en amuletos antiguos.", CategoryId = 2, ImageUrl = "/Images/dije.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 24, Name = "Aros Espiral Infinito", Price = 480.00M, ShortDescription = "Diseño de espiral fluida en plata bañada en oro.", LongDescription = "Geometría orgánica con juego de sombras y luces.", CategoryId = 3, ImageUrl = "/Images/aroschonki.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 25, Name = "Brazalete Rígido Esculpido", Price = 1350.00M, ShortDescription = "Estructura de oro sólido con textura martillada.", LongDescription = "Cada pieza es única.", CategoryId = 4, ImageUrl = "/Images/argolla.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 26, Name = "Horquilla Perla Regia", Price = 210.00M, ShortDescription = "Pasador de plata con perlas barrocas.", LongDescription = "Ideal para novias o eventos de gala.", CategoryId = 5, ImageUrl = "/Images/horquillaplata.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 27, Name = "Dúo Nocturno Anastasia", Price = 2950.00M, ShortDescription = "Conjunto de gargantilla y sortija con aros.", LongDescription = "La nobleza de la plata en su máxima expresión.", CategoryId = 6, ImageUrl = "/Images/setsimple.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 28, Name = "Argolla Sello Natural", Price = 1100.00M, ShortDescription = "Argolla pensada en la simplicidad y majestuosidad de la naturaleza.", LongDescription = "Diseño minimalista que resalta la belleza natural.", CategoryId = 1, ImageUrl = "/Images/anillonaturaleza.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 29, Name = "Colgante Eclipse Negro", Price = 1600.00M, ShortDescription = "Collar de oro con dije negro.", LongDescription = "Diseño moderno que inspira elegancia y misterio.", CategoryId = 2, ImageUrl = "/Images/colgantecondijenegro.jpeg", InStock = true, IsFeatured = true },
                    new Product { ProductId = 30, Name = "Pendientes Cascada de Estrellas", Price = 640.00M, ShortDescription = "Largas tiras de diamantes que caen con ligereza.", LongDescription = "Efecto de cascada brillante.", CategoryId = 3, ImageUrl = "/Images/aroshoja.jpeg", InStock = true, IsFeatured = false },
                    new Product { ProductId = 31, Name = "Horquilla Oriental de Rubí", Price = 1250.00M, ShortDescription = "Horquilla de estilo oriental con rubíes incrustados.", LongDescription = "Un toque de lujo y sofisticación.", CategoryId = 5, ImageUrl = "/Images/horquillarubi.jpeg", InStock = true, IsFeatured = true }
                );

                context.SaveChanges();
            }
        }
    }
}