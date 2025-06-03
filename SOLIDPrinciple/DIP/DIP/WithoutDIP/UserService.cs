namespace DIP.WithoutDIP
{
    public class UserService
    {
        private SqlDb SqlDb = new SqlDb();
        private MongoDb MongoDb = new MongoDb();

        public void SaveToSqlDB(string user)
        {
            SqlDb.SaveToSqlDB(user);
        }

        public void SaveToMongoDb(string user)
        {
            MongoDb.SaveToMongoDb(user);
        }
    }
}
