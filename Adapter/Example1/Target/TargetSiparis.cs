using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example1.Target
{
    public class TargetSiparis
    {
        public virtual void Siparis()
        {
            Console.WriteLine("Gitar sipariş başarı ile geçekleştirildi");
        }

    }
}
