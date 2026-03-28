using Microsoft.EntityFrameworkCore;

namespace web_05.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly JoyeriaDbContext _context;

        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();

        private ShoppingCart(JoyeriaDbContext context)
        {
            _context = context;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            var context = services.GetRequiredService<JoyeriaDbContext>();
            var cart = new ShoppingCart(context) { ShoppingCartId = cartId };

            session?.SetString("CartId", cartId);

            return cart;
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem = ShoppingCartItems
                .FirstOrDefault(s => s.Product.ProductId == product.ProductId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    Product = product,
                    Amount = 1,
                    ShoppingCartId = ShoppingCartId
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = ShoppingCartItems
                .FirstOrDefault(s => s.Product.ProductId == product.ProductId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();
            return localAmount;
        }

      public List<ShoppingCartItem> GetShoppingCartItems()
{
    // Forzamos que siempre traiga los datos frescos de la base de datos
    ShoppingCartItems = _context.ShoppingCartItems
        .Where(c => c.ShoppingCartId == ShoppingCartId)
        .Include(s => s.Product)
        .ToList();

    return ShoppingCartItems;
}

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Amount)
                .Sum();

            return total;
        }
    }
}