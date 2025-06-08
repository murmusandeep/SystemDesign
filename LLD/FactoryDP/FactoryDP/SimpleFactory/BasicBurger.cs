namespace FactoryDP.SimpleFactory
{
    public class BasicBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Burger");
        }
    }
}
