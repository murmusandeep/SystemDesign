using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory
{
    public class PremiumWheatGarlicBread : IGralicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Premium Wheat Garlic Bread");
        }
    }
}
