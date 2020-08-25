using Facade.Example1.Facade;
using Facade.Example1.Model;
using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //example1
            SiparisFacade siparisFacade = new SiparisFacade();
            List<SepettekiUrun> urunler = new List<SepettekiUrun>
            {
                new SepettekiUrun{Id=1, Adet=1, UrunAdi="x" , Fiyat=10},
                new SepettekiUrun{Id=2, Adet=2, UrunAdi="xy" , Fiyat=10},
                new SepettekiUrun{Id=3, Adet=1, UrunAdi="xyz" , Fiyat=10}
            };
            siparisFacade.SiparisVer("Parla", "forestkargo", urunler);
            Console.ReadKey();
        }
    }
}
