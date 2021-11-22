using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.BicyleRent
{
    public class Bicyle
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public double JantBoyutu { get; set; }
        public int VitesSayisi { get; set; }

        public void BicyleInfo()
        {
            Console.WriteLine("Bisiklet Bilgileri");
            Console.WriteLine($"Bisiklet Id : {Id}, Marka : {Marka}, Jant Boyutu : {JantBoyutu}, Vites Sayisi: {VitesSayisi}");
        }
    }
}
