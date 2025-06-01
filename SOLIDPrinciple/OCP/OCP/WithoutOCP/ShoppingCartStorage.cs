namespace OCP.WithoutOCP
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
            Console.WriteLine("Saving Shopping Cart to SQL database");
        }

        public void SaveToMongoDB()
        {
            Console.WriteLine("Saving Shopping Cart to Mongo database");
        }

        public void SaveToFile()
        {
            Console.WriteLine("Saving Shopping Cart to File");
        }
    }
}
