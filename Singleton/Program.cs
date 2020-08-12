using Singleton.Example1;
using Singleton.Example2;
using System;

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
            Console.WriteLine("Eager initialization instance hashcode:{0}" , eagerInitialization.GetHashCode());

            ///Static Block Initialization
            var staticBlockInstance = StaticBlockInitialization.getInstance();
            Console.WriteLine("Static Block initialization instance hashcode:{0}", staticBlockInstance.GetHashCode());
            ///Lazy Initilization
            var lazyInitilization = LazyInitialization.getInstance();
            Console.WriteLine("Lazy initialization instance hashcode:{0}",lazyInitilization.GetHashCode());
            
            Console.ReadKey();
        }
    }
}
