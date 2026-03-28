using web_05.Models;

namespace web_05.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Product Product { get; set; } = default!;   // Cambiado de Pie a Product

        public int Amount { get; set; }

        public string? ShoppingCartId { get; set; }        // Identificador del carrito (por sesión)
    }
}