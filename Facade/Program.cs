using Facade.Example1.Facade;
using Facade.Example1.Model;
using System;
using System.Collections.Generic;
using Facade.Example2;
using Facade.Example3.Facade;
using Facade.Example3.Model;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //example1
            Console.WriteLine("");
            Console.WriteLine("EXAMPLE 1");
            Console.WriteLine("");
            SiparisFacade siparisFacade = new SiparisFacade();
            List<SepettekiUrun> urunler = new List<SepettekiUrun>
            {
                new SepettekiUrun{Id=1, Adet=1, UrunAdi="x" , Fiyat=10},
                new SepettekiUrun{Id=2, Adet=2, UrunAdi="xy" , Fiyat=10},
                new SepettekiUrun{Id=3, Adet=1, UrunAdi="xyz" , Fiyat=10}
            };
            siparisFacade.SiparisVer("Parla", "forestkargo", urunler);
            Console.WriteLine("---------------------------------------------------");




            //example2
            Console.WriteLine("EXAMPLE 2");
            Console.WriteLine("");
            FacadeBank facade = new FacadeBank();
            facade.KrediKullan(new MusteriInfo {Ad= "Parla", MusteriNumarasi = 123456, TcNo ="19272623423"},90000);
            Console.WriteLine("---------------------------------------------------");




            //example3
            Console.WriteLine("EXAMPLE 3");

            Customer customer1 = new Customer { IDNo = "1245203836", Fullname = "Ahmet", CustomerNumber = 11243, CashAmount = 3456090.25M };
            Customer customer2 = new Customer() { IDNo = "2342342342", Fullname = "Mehmet", CustomerNumber = 123123, CashAmount = 34929272.36M };

            FacadeCustomer facadeCustomer = new FacadeCustomer();
            facadeCustomer.SendEFT(customer1, customer2, 123456);
            facadeCustomer.UseCredit(customer2);



            Console.ReadKey();
        }
    }
}

// facade desen class kullanımını seviyelendiren bir tasarım desenidir.Sisttemin karmasıklığını gizler ve istemciye sisteme erişebilecekleri bir ara birim sağlar.
// yani kısaca, bir sistemin alt parçalarını oluşturan classları istemciden soyutlayarak kullanımı daha kolaylaştırmak için kullanılan bir tasarım kalıbıdır.
// mimarisel açıdan ise, karmaşık ve detaylı bir sistemi organize eden ve bir bütün olarak clientlara sunan yapıdır.