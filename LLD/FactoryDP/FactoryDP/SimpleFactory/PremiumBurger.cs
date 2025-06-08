namespace FactoryDP.SimpleFactory
{
    public class PremiumBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premium Burger");
        }
    }
}
