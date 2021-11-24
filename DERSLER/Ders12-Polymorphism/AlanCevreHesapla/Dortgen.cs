using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AlanCevreHesapla
{
    class Dortgen :Hesapla
    {
        private int _en;
        private int _boy;

        public Dortgen(int en, int boy)
        {
            _en = en;
            _boy= boy;

        }

        public override void AlanHesapla()
        {
            int alan = _boy * _en;
            Console.WriteLine($"Dörtgen alanı : {alan}");
        }

        public override void CevreHesapla()
        {
            int cevre = 2 * (_boy + _en);
            Console.WriteLine($"Dörtgen çevresi : {cevre}");
        }
    }
}
