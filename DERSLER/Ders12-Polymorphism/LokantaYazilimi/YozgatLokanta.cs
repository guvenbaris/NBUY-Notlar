using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.LokantaYazilimi
{
    class YozgatLokanta :Lokanta
    {
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Yozgat için lokanta harcı : 1500");
        }
    }
}
