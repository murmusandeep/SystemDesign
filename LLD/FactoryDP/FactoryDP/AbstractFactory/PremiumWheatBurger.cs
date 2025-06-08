using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class PremiumWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premium Wheat Burger");
        }
    }
}
