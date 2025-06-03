using DIP.WithDIP.Interfaces;

namespace DIP.WithDIP
{
    public class SqlDb : IDatabase
    {
        public void Save(string user)
        {
            Console.WriteLine("Save in SQL DB " + user);
        }
    }
}
