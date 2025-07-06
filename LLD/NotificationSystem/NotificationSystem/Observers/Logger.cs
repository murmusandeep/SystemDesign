using NotificationSystem.Interfaces;
using NotificationSystem.Services;

namespace NotificationSystem.Observers
{
    //public class Logger : IObserver
    //{
    //    private NotificationObservable _observable;

    //    public Logger(NotificationObservable observable)
    //    {
    //        _observable = observable;
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Logging New Notification : \n" + _observable.GetNotificationContent());
    //    }
    //}

    public class Logger : IObserver
    {
        private readonly NotificationObservable _observable;

        public Logger()
        {
            _observable = NotificationService.Instance.GetObservable();
            _observable.AddObserver(this);
        }

        public Logger(NotificationObservable observable)
        {
            _observable = observable;
            _observable.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine("Logging New Notification : \n" + _observable.GetNotificationContent());
        }
    }
}
