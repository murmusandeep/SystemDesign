using StrategyDP.Strategys.CompanableStrategy;
using StrategyDP.Strategys.FlyableStrategy;
using StrategyDP.Strategys.TalkableStrategy;
using StrategyDP.Strategys.WalkableStrategy;

namespace StrategyDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var companionRobot = new Robot(new NormalTalk(), new NormalWalk(), new NormalFly(), new CompanionProjection());

            companionRobot.Talk();
            companionRobot.Walk();
            companionRobot.Fly();
            companionRobot.Projection();

            Console.WriteLine();
            companionRobot.SetRobot(new NoTalk(), new NoWalk(), new NoFly(), new CompanionProjection());

            companionRobot.Talk();
            companionRobot.Walk();
            companionRobot.Fly();
            companionRobot.Projection();
        }
    }
}
