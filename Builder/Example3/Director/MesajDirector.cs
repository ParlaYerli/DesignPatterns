using Builder.Example3.IBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Director
{
    public class MesajDirector
    {
        private MesajBuilder mesajBuilder;
        public void Construction(MesajBuilder _mesajBuilder)
        {
            mesajBuilder = _mesajBuilder;
            mesajBuilder.SetMesajBasligi();
            mesajBuilder.SetMesajIcerigi();
            mesajBuilder.SetMesajImza();
        }
        public void Show()
        {
            Console.WriteLine("{0} : {1} , {2}",
                mesajBuilder.Mesaj.MesajBaslik,mesajBuilder.Mesaj.MesajIcerigi,mesajBuilder.Mesaj.MesajImza);
           
        }
    }
}
