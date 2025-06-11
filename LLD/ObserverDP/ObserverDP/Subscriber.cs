using ObserverDP.Interfaces;

namespace ObserverDP
{
    public class Subscriber : ISubscriber
    {
        private string _name;
        private Channel _channel;

        public Subscriber(string name, Channel channel)
        {
            _name = name;
            _channel = channel;
        }

        public void Update()
        {
            Console.WriteLine("Hey " + _name + ", " + this._channel.GetNewVideo());
        }
    }
}
