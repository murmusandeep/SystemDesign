using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.TalkableStrategy
{
    public class NoTalk : ITalkableRobot
    {
        public void Talk()
        {
            Console.WriteLine("No Talk");
        }
    }
}
