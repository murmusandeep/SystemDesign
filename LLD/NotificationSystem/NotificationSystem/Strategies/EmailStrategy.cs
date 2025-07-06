using NotificationSystem.Interfaces;

namespace NotificationSystem.Strategies
{
    public class EmailStrategy : INotificationStrategy
    {
        private string _emailId;

        public EmailStrategy(string emailId)
        {
            _emailId = emailId;
        }

        public void SendNotification(string content)
        {
            Console.WriteLine($"Sending Email Notification to: {_emailId}\n{content}");
        }
    }
}
