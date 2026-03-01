using StrategyDP.Interfaces;

namespace StrategyDP.Strategys.TalkableStrategy
{
    public class NormalTalk : ITalkableRobot
    {
        public void Talk()
        {
            Console.WriteLine("Normal Talk");
        }
    }
}
