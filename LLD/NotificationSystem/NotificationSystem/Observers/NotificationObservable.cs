using NotificationSystem.Interfaces;

namespace NotificationSystem.Observers
{
    public class NotificationObservable : IObservable
    {
        private List<IObserver> _observers = new();
        private INotification _currentNotification;

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void SetNotification(INotification notification)
        {
            _currentNotification = notification;
            NotifyObservers();
        }

        public INotification GetNotification() => _currentNotification;

        public string GetNotificationContent() => _currentNotification.GetContent();
    }
}
