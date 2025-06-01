namespace OCP.WithOCP
{
    public class ShoppingCart
    {
        private List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (Product product in _products)
            {
                totalPrice += product._price;
            }
            return totalPrice;
        }
    }
}
