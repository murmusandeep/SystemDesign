using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public class BasicBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Burger");
        }
    }
}
