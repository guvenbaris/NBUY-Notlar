using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Sahibinden
{
    public class Dizüstü : Bilgisayar
    {
        public string EkranBoyutu { get; set; }
        public int Agirlik { get; set; }

        public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine($"Marka : {base.Marka}, İşlemci : {base.Islemci}, Bellek : {base.Bellek}, HDD : {base.Hdd}, SSD : {base.Ssd}," +
                              $"Ethernet Var Mi : {base.EthernetVarMi}" +$" {this.EkranBoyutu}," +
                              $" Ağırlık : {this.Agirlik}");
        }
    }
}
