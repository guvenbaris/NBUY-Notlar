using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AlanCevreHesapla
{
    class Hesapla
    {
        virtual public void AlanHesapla()
        {
            Console.WriteLine("Alan hesaplandı : ");
        }

        virtual public void CevreHesapla()
        {
            Console.WriteLine("Cevre hesaplandı : ");
        }
    }
}
