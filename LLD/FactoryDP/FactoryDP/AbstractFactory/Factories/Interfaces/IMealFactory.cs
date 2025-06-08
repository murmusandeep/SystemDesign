using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory.Factories.Interfaces
{
    public interface IMealFactory
    {
        public IBurger CreateBurger(string type);
        public IGralicBread CreateGarlicBread(string type);
    }
}
