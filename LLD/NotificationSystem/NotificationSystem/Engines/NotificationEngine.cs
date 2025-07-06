using NotificationSystem.Interfaces;
using NotificationSystem.Observers;
using NotificationSystem.Services;

namespace NotificationSystem.Engines
{
    //public class NotificationEngine : IObserver
    //{
    //    private NotificationObservable _observable;
    //    private List<INotificationStrategy> _strategies = new();

    //    public NotificationEngine(NotificationObservable observable)
    //    {
    //        _observable = observable;
    //    }

    //    public void AddNotificationStrategy(INotificationStrategy strategy)
    //    {
    //        _strategies.Add(strategy);
    //    }

    //    public void Update()
    //    {
    //        var content = _observable.GetNotificationContent();
    //        foreach (var strategy in _strategies)
    //        {
    //            strategy.SendNotification(content);
    //        }
    //    }
    //}

    public class NotificationEngine : IObserver
    {
        private readonly NotificationObservable _observable;
        private readonly List<INotificationStrategy> _strategies = new();

        public NotificationEngine()
        {
            _observable = NotificationService.Instance.GetObservable();
            _observable.AddObserver(this);
        }

        public NotificationEngine(NotificationObservable observable)
        {
            _observable = observable;
        }

        public void AddNotificationStrategy(INotificationStrategy strategy)
        {
            _strategies.Add(strategy);
        }

        public void Update()
        {
            string content = _observable.GetNotificationContent();
            foreach (var strategy in _strategies)
                strategy.SendNotification(content);
        }
    }
}
