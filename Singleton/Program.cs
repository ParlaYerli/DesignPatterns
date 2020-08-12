using Singleton.Example1;
using Singleton.Example2;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourClass = MyClass.Instance;
            ourClass.Name = "Parla";
            ourClass.SaySomething();
            var tss = ThreadSafeSingleton.Instance;
            tss.Name = "Parla2";
            tss.SaySomething();
            ////////////////////////////////////////////

            var staticBlockInstance = StaticBlockInitialization.getInstance();
            Console.WriteLine(staticBlockInstance.GetHashCode());
            Console.ReadKey();
        }
    }
}
