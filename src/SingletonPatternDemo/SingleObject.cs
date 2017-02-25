namespace SingletonPatternDemo
{
    public class SingleObject
    {
        private static readonly SingleObject Instance = new SingleObject();

        static SingleObject()
        {
        }

        private SingleObject()
        {
        }

        public static SingleObject GetInstance()
        {
            return Instance;
        }

        //{

        //private SingleObject()

        //private static readonly object LockObj = new object();

        //private static SingleObject _instance = null;
        //}

        //public static SingleObject GetInstance()
        //{
        //    if (_instance == null)
        //        lock (LockObj)
        //        {
        //            if (_instance == null)
        //                return new SingleObject();
        //        }

        //    return _instance;
        //}
    }
}