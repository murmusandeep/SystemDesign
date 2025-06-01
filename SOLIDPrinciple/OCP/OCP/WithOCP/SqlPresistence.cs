namespace OCP.WithOCP
{
    public class SqlPresistence : Presistence
    {
        public override void Save(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Data saving to SQL");
        }
    }
}
