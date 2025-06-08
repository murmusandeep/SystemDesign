using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class BasicWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Wheat Burger");
        }
    }
}
