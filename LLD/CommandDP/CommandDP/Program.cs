using CommandDP.Concrete;
using CommandDP.Receivers;

namespace CommandDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var livingRoomLight = new Light();
            var ceilingFan = new Fan();

            var remote = new RemoteController();

            remote.SetCommand(0, new LightCommand(livingRoomLight));
            remote.SetCommand(1, new FanCommand(ceilingFan));

            Console.WriteLine("--- Toggling Light Button 0 ---");
            remote.PressButton(0); // ON
            remote.PressButton(0); // OFF

            Console.WriteLine("--- Toggling Fan Button 1 ---");
            remote.PressButton(1); // ON
            remote.PressButton(1); // OFF

            Console.WriteLine("--- Pressing Unassigned Button 2 ---");
            remote.PressButton(2); // No command assigned
        }
    }
}
