namespace SRP.WithSRP
{
    public class ShoppingCartStorage
    {
        private ShoppingCart _shoppingCart;

        public ShoppingCartStorage(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public void SaveToDB()
        {
            Console.WriteLine("Saving Shopping Cart to database");
        }
    }
}
