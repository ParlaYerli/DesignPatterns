using Builder.Example3.IBuilder;
using Builder.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.ConcreteBuilder
{
    public class BayramTebrikMesajBuilder : MesajBuilder
    {
        public BayramTebrikMesajBuilder() : base(MesajTipi.BayramTebrigi)
        {

        }
        public override void SetMesajBasligi()
        {
            Mesaj.MesajBaslik = "İyi bayramlaaaar!";
        }

        public override void SetMesajIcerigi()
        {
            Mesaj.MesajIcerigi = "Bayramınız kutlu olsun!!!!!!";
        }

        public override void SetMesajImza()
        {
            Mesaj.MesajImza = "Parla";
        }
    }
}
