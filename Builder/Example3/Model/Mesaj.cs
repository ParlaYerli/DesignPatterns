using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Model
{
    public class Mesaj
    {
        public string MesajBaslik { get; set; }
        public string MesajIcerigi { get; set; }
        public string MesajImza { get; set; }
        private MesajTipi _mesajTipi;
        public Mesaj(MesajTipi mesajTipi)
        {
            _mesajTipi = mesajTipi;
        }
    }
}
