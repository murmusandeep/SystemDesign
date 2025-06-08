namespace SingletonDP.SimpleSingleton
{
    public class Singleton
    {
        private static Singleton _singleton;

        private Singleton()
        {
            Console.WriteLine("Simple Singleton Constructor Called");
        }
        public static Singleton Instance
        {
            get
            {

                if (_singleton == null)
                {
                    _singleton = new Singleton();
                }

                return _singleton;
            }
        }
    }
}
