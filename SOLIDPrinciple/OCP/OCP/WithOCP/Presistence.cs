namespace OCP.WithOCP
{
    public abstract class Presistence
    {
        private ShoppingCart _shoppingCart;
        public abstract void Save(ShoppingCart shoppingCart);
    }
}
