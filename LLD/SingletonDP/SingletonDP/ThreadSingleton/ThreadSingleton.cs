namespace SingletonDP.ThreadSingleton
{
    public class ThreadSingleton
    {
        private static ThreadSingleton _instance;

        private static readonly object _lock = new object();
        private ThreadSingleton()
        {
            Console.WriteLine("Thread Singleton Constructor Called");
        }
        public static ThreadSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }

}
