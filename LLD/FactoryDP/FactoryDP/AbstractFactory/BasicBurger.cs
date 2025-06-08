using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class BasicBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Burger");
        }
    }
}
