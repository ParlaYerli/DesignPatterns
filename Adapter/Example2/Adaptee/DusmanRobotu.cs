using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example2.Adaptee
{
    public class DusmanRobotu 
    {
        Random random = new Random();
        public void Yumruk()
        {
            int yumrukHasari = random.Next(40) + 1;
            string hasar = Convert.ToString(yumrukHasari);
            Console.WriteLine("Robot yumruk atarak  "+ hasar+ "  hasar vermiştir");
        }
        public void Yurume()
        {
            int robotHizi = random.Next(40) + 1;
            string hiz = Convert.ToString(robotHizi);
            Console.WriteLine("Robot hızı  " + hiz + "  hasar vermiştir");
        }
        public void KontrolEden(string kullanici)
        {
            Console.WriteLine("Robot  " + kullanici + " tarafından yönetilmektedir.");
        }

    }
}
