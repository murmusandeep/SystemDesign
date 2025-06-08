using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class BasicWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Wheat Burger");
        }
    }
}
