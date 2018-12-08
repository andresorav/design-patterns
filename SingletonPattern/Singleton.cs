namespace SingletonPattern
{
    public class Singleton
    {
        private readonly string _name;
        private static Singleton _singletonInstance;
        
        private Singleton(string name = null)
        {
            _name = name;
        }

        public static Singleton CreateInstance(string name)
        {
            return _singletonInstance ?? (_singletonInstance = new Singleton(name));
        }

        public string GetName()
        {
            return _name;
        }
    }
}