using java.lang;
using Singleton.Example1;
using Singleton.Example2;
using System;
using System.Threading;
using System.Threading.Tasks;
using Thread = System.Threading.Thread;

namespace Singleton
{
    class Program
    { 
        private static void Write1() 
        {
            LazyInitialization lazy1 = LazyInitialization.getInstance();
            lazy1.WriteMessage("ben birinci threadim");
        }
        private static void Write2()
        {
            LazyInitialization lazy1 = LazyInitialization.getInstance();
            lazy1.WriteMessage("ben ikinci threadim");
        }
        private static void Write3()
        {
            ThreadSafeDoubleCheck safe1 = ThreadSafeDoubleCheck.Instance();
            safe1.WriteMessage("ben birinci threadim");
        }
        private static void Write4()
        {
            ThreadSafeDoubleCheck safe2 = ThreadSafeDoubleCheck.Instance();
            safe2.WriteMessage("ben ikinci threadim");
        }
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

            ////// Lazy Initilization
            /// tek thread ile çalışınca sıkıntı olmaz, tek thread ile verimli çalışır.3 farklı instance isteği için bir kez instance oluşur.

           /* LazyInitialization lazy1 = LazyInitialization.getInstance();
            lazy1.WriteMessage("ben birinci threadim");
            LazyInitialization lazy2 = LazyInitialization.getInstance();
            lazy2.WriteMessage("ben ikinci threadim");
            LazyInitialization lazy3 = LazyInitialization.getInstance();
            lazy3.WriteMessage("ben üçüncü threadim");*/
    

            /// fakat birden fazla thread ile aynı anda çalışında metod farklı instancelar üretmeye baslar ve bu durum, singleton patterninin prensiplerinin dışına çıkmasına sebep olur.
            Console.WriteLine("LAZY parallel thread working:");
            Parallel.Invoke(
                () => Write1(),
                () => Write2());


            ///ThreadSafeDoubleCheck
            Console.WriteLine("THREADSAFEDOUBLECHECK parallel thread working:");
            Parallel.Invoke(
                () => Write3(),
                () => Write4());
            Console.ReadKey();
        }
    }
}
