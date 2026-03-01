using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.WalkableStrategy
{
    public class NormalWalk : IWalkableRobot
    {
        public void Walk()
        {
            Console.WriteLine("Normal Walk");
        }
    }
}
