using Builder.Example3.IBuilder;
using Builder.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.ConcreteBuilder
{
    public class DogumGunuTebrikBuilder : MesajBuilder
    {

        public DogumGunuTebrikBuilder() : base (MesajTipi.DogumGunuTebrigi)
        {

        }
        public override void SetMesajBasligi()
        {
            Mesaj.MesajBaslik =" Nice yıllaraaaa!";
        }

        public override void SetMesajIcerigi()
        {
            Mesaj.MesajIcerigi = "Doğum Günün Kutlu Olsun !!!!! ";
        }

        public override void SetMesajImza()
        {
            Mesaj.MesajImza = "Parla";
        }
    }
}
