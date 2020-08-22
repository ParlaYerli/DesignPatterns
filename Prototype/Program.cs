using Prototype.Example1.Model;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            /// example1
            Oyun oyun1 = new Oyun(1,"counter strike","fps",true);
            Oyun oyun2= (Oyun)oyun1.Clone();
            if (oyun1.Equals(oyun2))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Eşit değil");
            }
            Console.ReadKey();
        }
    }
}
