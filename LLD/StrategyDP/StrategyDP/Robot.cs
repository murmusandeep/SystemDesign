using StrategyDP.Interfaces;

namespace StrategyDP
{
    public class Robot
    {
        private readonly ITalkableRobot _talkableRobot;
        private readonly IWalkableRobot _walkableRobot;
        private readonly IFlyableRobot _flyableRobot;
        private readonly IProjectable _projectable;

        public Robot(ITalkableRobot talkableRobot, IWalkableRobot walkableRobot, IFlyableRobot flyableRobot, IProjectable projectable)
        {
            _talkableRobot = talkableRobot;
            _walkableRobot = walkableRobot;
            _flyableRobot = flyableRobot;
            _projectable = projectable;
        }

        public void Talk()
        {
            _talkableRobot.Talk();
        }

        public void Walk()
        {
            _walkableRobot.Walk();
        }

        public void Fly()
        {
            _flyableRobot.Fly();
        }

        public void Projection()
        {
            _projectable.Projection();
        }
    }
}
