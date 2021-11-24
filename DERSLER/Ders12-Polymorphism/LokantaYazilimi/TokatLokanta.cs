using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.LokantaYazilimi
{
    class TokatLokanta : Lokanta
    {
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Tokat için lokanta harcı : 2000");
        }
    }
}
