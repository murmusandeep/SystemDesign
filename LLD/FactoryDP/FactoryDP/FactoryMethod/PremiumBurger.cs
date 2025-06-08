using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class PremiumBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premuim Burger");
        }
    }
}
