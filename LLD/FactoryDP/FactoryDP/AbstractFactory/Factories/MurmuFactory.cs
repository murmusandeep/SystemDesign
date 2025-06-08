using FactoryDP.AbstractFactory.Factories.Interfaces;
using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory.Factories
{
    public class MurmuFactory : IMealFactory
    {
        public IBurger CreateBurger(string type)
        {
            if (type.ToLower() == "basic")
            {
                return new BasicBurger();
            }
            else if (type.ToLower() == "standard")
            {
                return new StandardBurger();
            }
            else if (type.ToLower() == "premium")
            {
                return new PremiumBurger();
            }
            else
            {
                throw new ArgumentException("You have enter wrong type");
            }
        }

        public IGralicBread CreateGarlicBread(string type)
        {
            if (type.ToLower() == "basic")
            {
                return new BasicGarlicBread();
            }
            else if (type.ToLower() == "premium")
            {
                return new PremiumGarlicBread();
            }
            else
            {
                throw new ArgumentException("You have enter wrong type");
            }
        }
    }
}
