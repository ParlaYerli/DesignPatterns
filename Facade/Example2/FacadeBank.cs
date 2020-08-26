using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Example2
{
    public class FacadeBank
    {
        private Banka _banka;
        private MerkezBanka _merkezBanka;
        private Kredi _kredi;
        public FacadeBank()
        {
            _banka = new Banka();
            _merkezBanka = new MerkezBanka();
            _kredi = new Kredi();
        }

        public void KrediKullan(MusteriInfo musteri, decimal talep)
        {
            if (!_merkezBanka.KaraListeKontrol(musteri.TcNo) && _kredi.KrediKullanmaDurumu(musteri))
            {
                _banka.KrediyiKullan(musteri,talep);
                Console.WriteLine("kredi basarıyla gerçekleştirildi");
            }
        }
    }
}
