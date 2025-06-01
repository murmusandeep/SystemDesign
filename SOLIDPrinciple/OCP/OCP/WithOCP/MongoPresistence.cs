namespace OCP.WithOCP
{
    public class MongoPresistence : Presistence
    {
        public override void Save(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Data saving to Mongo");
        }
    }
}
