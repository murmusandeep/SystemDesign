using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            string burgerType = "standard";
            string garlicBreadType = "premium";

            SimpleFactory.BurgerFactory simpleBurgerFactory = new SimpleFactory.BurgerFactory();
            SimpleFactory.IBurger simpleBurger = simpleBurgerFactory.CreateBurger(burgerType);
            simpleBurger.Prepare();

            FactoryMethod.IBurgerFactory factoryMethodBurgerFactory = new FactoryMethod.Factories.KingBurger();
            IBurger factoryMethodBurger = factoryMethodBurgerFactory.CreateBurger(burgerType);
            factoryMethodBurger.Prepare();

            AbstractFactory.Factories.Interfaces.IMealFactory abstarctMealFactory = new AbstractFactory.Factories.KingFactory();
            AbstractFactory.Interfaces.IBurger abstractBurgerFactory = abstarctMealFactory.CreateBurger(burgerType);
            AbstractFactory.Interfaces.IGralicBread abstractGarlicFactory = abstarctMealFactory.CreateGarlicBread(garlicBreadType);
            abstractBurgerFactory.Prepare();
            abstractGarlicFactory.Prepare();
        }
    }
}
