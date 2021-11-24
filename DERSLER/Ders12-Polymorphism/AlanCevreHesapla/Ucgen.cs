using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AlanCevreHesapla
{
    class Ucgen : Hesapla
    {
        private int _yukseklik;
        private int _taban;
        private int _kenar1;
        private int _kenar2;

        public Ucgen(int yukseklik, int taban, int kenar1, int kenar2)
        {
            _yukseklik = yukseklik;
            _taban = taban;
            this._kenar1 = kenar1;
            this._kenar2 = kenar2;
        }
        public override void AlanHesapla()
        {
            int alan = (_taban * _yukseklik) / 2;
            Console.WriteLine($"Uçgenin alanı : {alan}");
        }
        public override void CevreHesapla()
        {
            int cevre = _kenar1 + _kenar2 + _taban;
            Console.WriteLine($"Uçgenin alanı : {cevre}");
        }
    }
}
