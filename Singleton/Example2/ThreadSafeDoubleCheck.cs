using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton.Example2
{
    public class ThreadSafeDoubleCheck
    {
        private static ThreadSafeDoubleCheck instance=null;
        private static object checkLock = new object();
        private static int counter = 0;
        private ThreadSafeDoubleCheck()
        {
            counter++;
            Console.WriteLine("ThreadSafeDoubleCheck için Kaç Kez Nesne Oluşturuldu-> " + counter.ToString());
        }
        public static ThreadSafeDoubleCheck Instance()
        {
            if (instance == null)
            {
                lock (checkLock)
                {
                    if (instance==null)
                    {
                        instance = new ThreadSafeDoubleCheck();
                    }
                }
            }
            return instance;
        }
        public void WriteMessage(string message)
        {
            Console.WriteLine("THREADSAFEDOUBLECHECK yöntemi için çalışan thread bilgileri --> ThreadID: {0},{1}",
            Thread.CurrentThread.ManagedThreadId, instance.GetHashCode());
            Console.WriteLine(message);
        }
    }
}

//bu yöntem ile sınıf sadece instance oluşturulurken sınıf senkronize edileceğinden performans sorununa yol açmaz 