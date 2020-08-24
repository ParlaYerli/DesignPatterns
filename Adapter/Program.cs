using Adapter.Example1.Adapter;
using Adapter.Example1.Target;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TargetSiparis targetSiparis = new AdapterSiparis();
            targetSiparis.Siparis();
            Console.ReadKey();
        }
    }
}

// Adaptee: mevcut sisteme uydurulmak istenen nesne
// Adapter: mevcut sisteme uydurma işlemi yapan nesne
// Target : İhtiyaç duyulan class veya interface