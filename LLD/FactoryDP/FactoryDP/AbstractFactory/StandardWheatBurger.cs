using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class StandardWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Standard Wheat Burger");
        }
    }
}
