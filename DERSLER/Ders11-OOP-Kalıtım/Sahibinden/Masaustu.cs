using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Sahibinden
{
    public enum Kasatipi
    {
        Dikey,Yatay,ThinClient
    } 
   public class Masaustu :Bilgisayar
    {
        public string KasaTipi { get; set; }
        public bool MonitorVarMi { get; set; }
        public Kasatipi  _Kasatipi { get; set; }

        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine($"Marka : {base.Marka}, İşlemci : {base.Islemci}, Bellek : {base.Bellek}, HDD : {base.Hdd}, SSD : {base.Ssd}," +
                                  $"Ethernet Var Mi : {base.EthernetVarMi},Wifi Var Mi : {base.WifiVarMi}, KasaTipi{_Kasatipi} ,Monitor : {this.MonitorVarMi}");
        }
    }
}
