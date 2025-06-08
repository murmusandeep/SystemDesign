using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class PremiumBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premuim Burger");
        }
    }
}
