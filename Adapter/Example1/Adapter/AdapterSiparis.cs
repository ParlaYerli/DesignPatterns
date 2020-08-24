using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Example1.Target;
using Adapter.Example1.Adaptee;

namespace Adapter.Example1.Adapter
{
    public class AdapterSiparis : TargetSiparis
    {
        private AdapteeKemence adaptee = new AdapteeKemence();
        public override void Siparis()
        {
            adaptee.KemenceSiparisi();
        }
    }
}
