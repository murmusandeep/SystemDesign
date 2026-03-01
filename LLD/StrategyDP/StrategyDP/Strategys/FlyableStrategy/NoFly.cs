using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.FlyableStrategy
{
    public class NoFly : IFlyableRobot
    {
        public void Fly()
        {
            Console.WriteLine("No Fly");
        }
    }
}
