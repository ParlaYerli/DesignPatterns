using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton.Example2
{
    public class LazyInitialization
    {
        private static LazyInitialization instance=null;  
        private static int counter = 0;
        private LazyInitialization()
        {
            counter++;
            Console.WriteLine("Lazy için Kaç Kez Nesne Oluşturuldu --> {0}", counter.ToString());

        }
        public static LazyInitialization getInstance()
        {
            if (instance == null)
            {
                instance = new LazyInitialization();
            }
            return instance;
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine("LAZY yöntemi için çalışan thread bilgileri --> ThreadID: {0},{1}",
            Thread.CurrentThread.ManagedThreadId, instance.GetHashCode());
            Console.WriteLine(message);
        }
    }
}
//Bu yöntemde sınıfın instancei, o sınıfa erişilmek istenildiğinde oluşturulur.
//Eğer bu sınıfa birden fazla thread erişmiyorsa sorunsuz olarak çalışır.
//Birden fazla instanceın oluşturulduğu yere aynı anda girerse farklı instancelar oluşur.
//Bu durum singleton ilkesine aykırıdır.Farklı threadler olmadığı zaman faydalıdır.