using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class StandardWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Standard Wheat Burger");
        }
    }
}
