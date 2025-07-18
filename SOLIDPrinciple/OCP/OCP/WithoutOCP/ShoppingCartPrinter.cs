﻿namespace OCP.WithoutOCP
{
    public class ShoppingCartPrinter
    {
        private ShoppingCart _shoppingCart;

        public ShoppingCartPrinter(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Shopping Cart Invoice");
            foreach (Product product in _shoppingCart.GetProducts())
            {
                Console.WriteLine(product._name + " - $" + product._price);
            }

            Console.WriteLine("Total: $" + _shoppingCart.CalculateTotalPrice());
        }
    }
}
