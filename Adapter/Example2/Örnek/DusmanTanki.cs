using Adapter.Example2.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example2.Örnek
{
    public class DusmanTanki : IDusman
    {
        Random random = new Random();
        public void AracHizi()
        {
            int arachizi = random.Next(20) + 1;
            string hiz = Convert.ToString(arachizi);
            Console.WriteLine("Tank " + hiz +"   km hızla gitmektedir.");
        }

        public void Silah()
        {
            int silahHasari = random.Next(20) + 1;
            string hasar = Convert.ToString(silahHasari);
            Console.WriteLine("Tank   " + hasar + "   hasar verir.");
        }

        public void SurucuIsmi(string isim)
        {
            Console.WriteLine("Tankı   " +isim +"    kullanmaktadır.");
        }
    }
}
