using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class StandardBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Standard Burger");
        }
    }
}
