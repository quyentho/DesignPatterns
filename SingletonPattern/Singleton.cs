using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();
        private Singleton()
        {
            Console.WriteLine("Im a singleton");
        }

        public static Singleton GetInstance()
        {
            if (_instance is null)
            {
                // in multi threaded app, there maybe multiple thread go to this line at the same time,
                // then it should wait for only one thread to obtain the lock.
                lock (_lock)
                {
                    // recheck because after the lock is release,
                    // we want to make sure only the first
                    // thread will be able to new up an instance.
                    if (_instance == null)
                    {
                        Console.WriteLine("Instance is null, create an instance");
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }

    }
}
