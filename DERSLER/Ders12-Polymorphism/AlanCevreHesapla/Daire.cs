using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AlanCevreHesapla
{
    class Daire :Hesapla
    {
        private int _yariCap;
        private float pi = 3.14f;

        public Daire(int yariCap)
        {
            _yariCap = yariCap;
        }

        public override void AlanHesapla()
        {
            double alan = this.pi * Math.Pow(_yariCap, 2);
            Console.WriteLine($"Dairenin alanı : {alan}");
        }
        public override void CevreHesapla()
        {
            double cevre = 2 * this.pi * _yariCap;
            Console.WriteLine($"Dairenin alanı : {cevre}");
        }
    }
}
