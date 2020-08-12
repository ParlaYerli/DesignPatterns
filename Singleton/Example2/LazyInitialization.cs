using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example2
{
    public class LazyInitialization
    {
        private static LazyInitialization instance;
        private LazyInitialization()
        {

        }
        public  static LazyInitialization getInstance()
        {
            if (instance==null)
            {
                 instance = new LazyInitialization();
            }
            return instance;
        }
    }
}
//Bu yöntemde sınıfın instancei, o sınıfa erişilmek istenildiğinde oluşturulur.
//Eğer bu sınıfa birden fazla thread erişmiyorsa sorunsuz olarak çalışır.
//Birden fazla instanceın oluşturulduğu yere aynı anda girerse farklı instancelar oluşur.
//Bu durum singleton ilkesine aykırıdır.Farklı threadler olmadığı zaman faydalıdır.