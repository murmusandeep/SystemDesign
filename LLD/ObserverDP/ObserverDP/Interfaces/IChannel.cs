namespace ObserverDP.Interfaces
{
    public interface IChannel
    {
        public void Subscribe(ISubscriber subscriber);
        public void Unsubscribe(ISubscriber subscriber);
        public void NotifySubscribers();
    }
}
