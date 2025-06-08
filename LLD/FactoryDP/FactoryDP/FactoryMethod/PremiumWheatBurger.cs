using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class PremiumWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premium Wheat Burger");
        }
    }
}
