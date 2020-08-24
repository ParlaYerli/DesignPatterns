using Adapter.Example1.Adapter;
using Adapter.Example1.Target;
using Adapter.Example2.Adapter;
using Adapter.Example2.Örnek;
using Adapter.Example2.Target;
using Adapter.Example3.Adaptee;
using Adapter.Example3.Adapter;
using Adapter.Example3.Ornek;
using Adapter.Example3.Target;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // example 1
            TargetSiparis targetSiparis = new AdapterSiparis();
            targetSiparis.Siparis();
            Console.WriteLine("");

            // example 2
            IDusman dusman = new DusmanRobotuAdapter();
            dusman.AracHizi();
            dusman.Silah();
            dusman.SurucuIsmi("parla");

            IDusman dusman1 = new DusmanTanki();
            dusman1.AracHizi();
            dusman1.Silah();
            dusman1.SurucuIsmi("ayse");
            Console.WriteLine("");

            //example3
            Fax fax = new Fax { FaxErrorCode = 001, ErrorDescription = "Cevap yok" };
            IError[] error = { 
            new DbError { ErrorNumber=002, Description="Veri bulunamadı"},
            new ServiceError{ ErrorNumber=003, Description = "yetki sağlanamadı"},
            new FaxAdapter(fax)
            };
            foreach (var item in error)
            {
                item.SendMail();
            }

            Console.ReadKey();
        }
    }
}

// Adaptee: mevcut sisteme uydurulmak istenen nesne
// Adapter: mevcut sisteme uydurma işlemi yapan nesne
// Target : İhtiyaç duyulan class veya interface