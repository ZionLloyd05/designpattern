namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton? _instance;

        private Singleton() { }

        public static Singleton Create()
        {
            _instance ??= new Singleton();
            return _instance;
        }
    }
}