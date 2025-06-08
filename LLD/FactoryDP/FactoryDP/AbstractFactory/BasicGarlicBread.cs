using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class BasicGarlicBread : IGralicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Garlic Bread");
        }
    }
}
