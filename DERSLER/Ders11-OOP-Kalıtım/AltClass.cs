using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım
{
    public class AltClass
    {
        public string AdSoyad { get; set; }
        public DateTime KayitTarihi { get; set; }

        public void IlanTarihiYaz()
        {
            Console.WriteLine($"Ilan tarihi : {KayitTarihi}");
        }
        public void AdSoyadYaz()
        {
            Console.WriteLine($"Ad Soyad :  : {AdSoyad}");
        }
    }
}
