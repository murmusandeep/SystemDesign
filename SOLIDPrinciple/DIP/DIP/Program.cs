
namespace DIP
{
    public class Program
    {
        static void Main(string[] args)
        {
            WithoutDIP.UserService withoutDIPUser = new WithoutDIP.UserService();
            withoutDIPUser.SaveToSqlDB("Sandeep");
            withoutDIPUser.SaveToMongoDb("Anid");

            Console.WriteLine();

            WithDIP.MongoDb withDIPSql = new WithDIP.MongoDb();
            WithDIP.UserService withDIPUser = new WithDIP.UserService(withDIPSql);
            withDIPUser.storeUser("Sumit");
        }
    }
}
