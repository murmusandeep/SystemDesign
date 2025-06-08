using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class PremiumGarlicBread : IGralicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Basic Premium Garlic Bread");
        }
    }
}
