using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.WalkableStrategy
{
    public class NoWalk : IWalkableRobot
    {
        public void Walk()
        {
            Console.WriteLine("No Walk");
        }
    }
}
