using NotificationSystem.Interfaces;
using NotificationSystem.Observers;

namespace NotificationSystem.Services
{
    //public class NotificationService
    //{
    //    private static NotificationService _instance;
    //    private NotificationObservable _observable;
    //    private List<INotification> _notifications = new();

    //    private NotificationService()
    //    {
    //        _observable = new NotificationObservable();
    //    }

    //    public static NotificationService Instance => _instance ??= new NotificationService();

    //    public NotificationObservable GetObservable() => _observable;

    //    public void SendNotification(INotification notification)
    //    {
    //        _notifications.Add(notification);
    //        _observable.SetNotification(notification);
    //    }
    //}

    public class NotificationService
    {
        private static NotificationService _instance;
        private readonly NotificationObservable _observable = new();
        private readonly List<INotification> _notifications = new();

        private NotificationService() { }

        public static NotificationService Instance => _instance ??= new NotificationService();

        public NotificationObservable GetObservable() => _observable;

        public void SendNotification(INotification notification)
        {
            _notifications.Add(notification);
            _observable.SetNotification(notification);
        }
    }
}
