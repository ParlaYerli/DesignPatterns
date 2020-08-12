
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Singleton.Example2
{
    public class ThreadSafeSyncronized
    {
        private static ThreadSafeSyncronized instance;
        private static object synLock = new object();

        private ThreadSafeSyncronized() { }
        public static ThreadSafeSyncronized getInstance()
        {
            lock (synLock)
            {
                instance = new ThreadSafeSyncronized();
            }
            return instance;
        }

        public void sampleMethodA()
        {
            Console.WriteLine("This is worker thread. ThreadID: {0},{1}",
         Thread.CurrentThread.ManagedThreadId, instance.GetHashCode());
        }

        public void sampleMethodB()
        {
            Console.WriteLine("This is worker thread. ThreadID: {0},{1}",
         Thread.CurrentThread.ManagedThreadId, instance.GetHashCode());
        }
    }   
}
//metod herhangi bir thread tarafından çağrıldığı anda diğer threadler tarafından çağrıldığı anda diğer threadler
//bu sınıfa erişemez ve birden fazla instance oluşturmanın önüne geçilmiş olur.
//diğer threadlerin bu kısma girebilmesi içimn ilgili threadin lock kısmından çıkması gerekir.
//bu durum performans ile ilgili sıkıntı çıkarabilir.her getInstance() metodu çağrıldığında
// baska bir thread , ilgili metodu çağırdığında kilitleme işlemi gerçekleşir ve bu çok maliyetli iştir.