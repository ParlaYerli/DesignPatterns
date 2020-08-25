using Facade.Example1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example1.Business
{
    public class SiparisIslemleri
    {
        public int SiparisEkle(DateTime siparisTarihi,Musteri musteri,KargoSirketi kargoSirketi)
        {
            Console.WriteLine("{0} tarihinde {1} isimli müşteri siparişi eklendi. Seçilen kargo şirketi:{2} ", siparisTarihi.ToString(), musteri.Ad, kargoSirketi.Ad);
            return 1;
        }
    }
}
