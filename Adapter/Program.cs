using Adapter.Example1.Adapter;
using Adapter.Example1.Target;
using Adapter.Example2.Adapter;
using Adapter.Example2.Örnek;
using Adapter.Example2.Target;
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

            // example 2
            IDusman dusman = new DusmanRobotuAdapter();
            dusman.AracHizi();
            dusman.Silah();
            dusman.SurucuIsmi("parla");

            IDusman dusman1 = new DusmanTanki();
            dusman1.AracHizi();
            dusman1.Silah();
            dusman1.SurucuIsmi("ayse");
            Console.ReadKey();
        }
    }
}

// Adaptee: mevcut sisteme uydurulmak istenen nesne
// Adapter: mevcut sisteme uydurma işlemi yapan nesne
// Target : İhtiyaç duyulan class veya interface