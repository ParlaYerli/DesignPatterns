using Adapter.Example2.Adaptee;
using Adapter.Example2.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example2.Adapter
{
    public class DusmanRobotuAdapter : IDusman
    {
        DusmanRobotu dusmanRobotu = new DusmanRobotu();
        public void AracHizi()
        {
            dusmanRobotu.Yurume();
        }
        public void Silah()
        {
            dusmanRobotu.Yumruk();
        }

        public void SurucuIsmi(string isim)
        {
            dusmanRobotu.KontrolEden(isim);
        }
    }
}
