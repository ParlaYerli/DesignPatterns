using Prototype.Example1.ConcretePrototype;
using Prototype.Example2.ConcretePrototype;
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

            /// example2 
            Employee employee = new Employee();
            employee.Name = "parla";
            employee.Department = "computer engineering";

            Employee employee1 = employee.Clone();
            employee1.Name = "ömer";
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee1.Name);
            Console.ReadKey();
        }
    }
}
// Abstract Prototype : yeni nesnelerin kopyalanmasını sağlayan ve bu işlem için Clone metodunu barındıran bir sınıftır. 
// Concrete Prototype : abstract sınıfı uygulayacak olan ve projede herhangi bir amaç için kullanılacak olan nesnelerdir.
//yani prototype design patterni uygulayacağımız projedeki sınıflarımızdır.