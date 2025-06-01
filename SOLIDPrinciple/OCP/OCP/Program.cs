using OCP.WithOCP;

namespace OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            WithoutOCP.ShoppingCart withoutocpShoppingCart = new WithoutOCP.ShoppingCart();
            withoutocpShoppingCart.AddProduct(new WithoutOCP.Product("PS5", 2000));
            withoutocpShoppingCart.AddProduct(new WithoutOCP.Product("GTA 6", 1000));
            WithoutOCP.ShoppingCartPrinter withsrpShoppingCartPrinter = new WithoutOCP.ShoppingCartPrinter(withoutocpShoppingCart);
            withsrpShoppingCartPrinter.PrintInvoice();
            WithoutOCP.ShoppingCartStorage withsrpShoppingCartStorage = new WithoutOCP.ShoppingCartStorage(withoutocpShoppingCart);
            withsrpShoppingCartStorage.SaveToFile();

            Console.WriteLine();

            WithOCP.ShoppingCart withocpShoppingCart = new WithOCP.ShoppingCart();
            withocpShoppingCart.AddProduct(new WithOCP.Product("PS5", 2000));
            withocpShoppingCart.AddProduct(new WithOCP.Product("GTA 6", 1000));
            WithOCP.ShoppingCartPrinter withOCPShoppingCartPrinter = new WithOCP.ShoppingCartPrinter(withocpShoppingCart);
            withsrpShoppingCartPrinter.PrintInvoice();
            Presistence sql = new SqlPresistence();
            Presistence mongo = new MongoPresistence();
            sql.Save(withocpShoppingCart);
            mongo.Save(withocpShoppingCart);
        }
    }
}
