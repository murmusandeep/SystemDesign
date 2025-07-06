using NotificationSystem.Interfaces;

namespace NotificationSystem.Strategies
{
    public class SMSStrategy : INotificationStrategy
    {
        private string _mobileNumber;

        public SMSStrategy(string mobileNumber)
        {
            _mobileNumber = mobileNumber;
        }

        public void SendNotification(string content)
        {
            Console.WriteLine($"Sending SMS Notification to: {_mobileNumber}\n{content}");
        }
    }
}
