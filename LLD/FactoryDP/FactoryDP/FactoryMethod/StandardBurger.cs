using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class StandardBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Standard Burger");
        }
    }
}
