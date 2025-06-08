namespace FactoryDP.SimpleFactory
{
    public class StandardBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Standard Burger");
        }
    }
}
