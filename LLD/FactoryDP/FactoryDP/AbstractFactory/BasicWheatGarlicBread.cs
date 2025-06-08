using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class BasicWheatGarlicBread : IGralicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Wheat Garlic Bread");
        }
    }
}
