namespace SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            WithoutSRP.ShoppingCart withoutsrpShoppingCart = new WithoutSRP.ShoppingCart();

            withoutsrpShoppingCart.AddProduct(new WithoutSRP.Product("Laptop", 1500));
            withoutsrpShoppingCart.AddProduct(new WithoutSRP.Product("Mouse", 200));
            withoutsrpShoppingCart.PrintInvoice();
            withoutsrpShoppingCart.SaveToDB();

            Console.WriteLine();

            WithSRP.ShoppingCart withsrpShoppingCart = new WithSRP.ShoppingCart();
            withsrpShoppingCart.AddProduct(new WithSRP.Product("PS5", 2000));
            withsrpShoppingCart.AddProduct(new WithSRP.Product("GTA 6", 1000));
            WithSRP.ShoppingCartPrinter withsrpShoppingCartPrinter = new WithSRP.ShoppingCartPrinter(withsrpShoppingCart);
            withsrpShoppingCartPrinter.PrintInvoice();
            WithSRP.ShoppingCartStorage withsrpShoppingCartStorage = new WithSRP.ShoppingCartStorage(withsrpShoppingCart);
            withsrpShoppingCartStorage.SaveToDB();
        }
    }
}
