using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example1
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _padlock = new object();
        public string Name { get; set; }
        public int NodeId { get; set; }
        private ThreadSafeSingleton()
        {

        }
        

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance==null)
                {
                    lock (_padlock)
                    {
                        _instance = new ThreadSafeSingleton();
                        _instance.Name = "Ayse";
                    }
                    
                }
                return _instance;
            }
        }
        public void SaySomething()
        {
            Console.WriteLine("ThreadSafeSingleton class working.. ");
        }
    }
}
