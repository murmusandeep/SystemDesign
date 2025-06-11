using ObserverDP.Interfaces;

namespace ObserverDP
{
    public class Channel : IChannel
    {
        private List<ISubscriber> _subscribers;
        private string _name;
        private string _latestVideo;

        public Channel(string name)
        {
            _name = name;
            _subscribers = new List<ISubscriber>();
        }
        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void UploadVideo(string title)
        {
            _latestVideo = title;
            Console.WriteLine("[" + _name + " uploaded " + title + "]");
            NotifySubscribers();
        }

        public string GetNewVideo()
        {
            return "Checkout New Video : " + _latestVideo;
        }
    }
}
