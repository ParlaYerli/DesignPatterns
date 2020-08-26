using Decorator.Example1;
using Decorator.Example1.Decorator;
using Decorator.Example2;
using Decorator.Example2.Decorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // example1
            Console.WriteLine("example 1 ---------");
            string to = "parla";
            string from = "ayse";
            IMail mail = new  GenelMail(from,to);

            IMail imzalıMail = new ImzaDecorator(mail, "engineering");
            imzalıMail.Send();
            IMail sifreleMail = new SifreleDecorator(mail);
            sifreleMail.Send();

            // example2 
            Console.WriteLine("example 2 ----------");
            Car car = new Car() { Model = "Astra", Brand = "Opel", Price = 35.1m, Description = "New car added." };
            car.PrintDetail();

            ICarDecorator carDecoratorABS = new ABSDecorator(car);
            carDecoratorABS.PrintDetail();
            ICarDecorator carDecoratorAir = new AirBagDecorator(car);
            carDecoratorAir.PrintDetail();
            Console.ReadKey();
        }
    }
}
// aynı veri üzerinde birden fazla değişiklik yapılması gereken durumlarda kullanılır.bu sayede ; yeni bir kod eklemek ,eski kodlara herhangi bir sekilde dokunmadan yeni bir sınıf yazmak yeterli olmaktadır.
// loosely-coupled uygulamalar yapmayı sağlar.
// runtime zamanında bir nesnye yeni özellikler eklenmesini sağlar.
// özellikleri kalıtım yolu dışında composition ve delegation ile de alınabilmesini sağlar.
// open-closed prensibinin uygulandığı tasarım desenidir.(sınıfların değiştirimeye kapalı, geliştirilmeye açık olma prensibi)