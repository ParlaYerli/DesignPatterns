using Builder.Example3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.IBuilder
{
    public abstract class MesajBuilder
    {
        private Mesaj _mesaj;
        public Mesaj Mesaj {
            get
            {
                return _mesaj;
            }
        }
        public MesajBuilder(MesajTipi mesajTipi)
        {
            _mesaj = new Mesaj(mesajTipi);
        }
        public abstract void SetMesajBasligi();
        public abstract void SetMesajIcerigi();
        public abstract void SetMesajImza();
    }
}