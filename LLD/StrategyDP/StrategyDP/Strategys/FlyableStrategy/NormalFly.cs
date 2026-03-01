using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.FlyableStrategy
{
    public class NormalFly : IFlyableRobot
    {
        public void Fly()
        {
            Console.WriteLine("Normal Fly");
        }
    }
}
