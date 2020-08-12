using java.lang;
using Singleton.Example1;
using Singleton.Example2;
using System;
using System.Threading;
using Thread = System.Threading.Thread;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////Example1
            var ourClass = MyClass.Instance;
            ourClass.Name = "Parla";
            ourClass.SaySomething();
            var tss = ThreadSafeSingleton.Instance;
            tss.Name = "Parla2";
            tss.SaySomething();


            //////////////////Example2
            ///Eager Initialization
            var eagerInitialization = EagerInitialization.GetEagerInitialization();
            Console.WriteLine("Eager initialization instance hashcode:{0}", eagerInitialization.GetHashCode());

            ///Static Block Initialization
            var staticBlockInstance = StaticBlockInitialization.getInstance();
            Console.WriteLine("Static Block initialization instance hashcode:{0}", staticBlockInstance.GetHashCode());
            ///Lazy Initilization
            var lazyInitilization = LazyInitialization.getInstance();
            Console.WriteLine("Lazy initialization instance hashcode:{0}", lazyInitilization.GetHashCode());
            ///ThreadSafeSyncronized
            ThreadSafeSyncronized threadSafe = ThreadSafeSyncronized.getInstance();
            Thread thread1 = new Thread(new ThreadStart(threadSafe.sampleMethodA));
            thread1.Start();
            ThreadSafeSyncronized threadSafe2 = ThreadSafeSyncronized.getInstance();
            Thread thread2 = new Thread(new ThreadStart(threadSafe2.sampleMethodB));
            thread2.Start();
            Console.ReadKey();
        }
    }
}
