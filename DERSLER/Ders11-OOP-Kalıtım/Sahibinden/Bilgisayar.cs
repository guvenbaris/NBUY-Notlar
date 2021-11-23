using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Sahibinden
{
    public class Bilgisayar : Ilan
    {
        public string Marka { get; set; }
        public string Islemci { get; set; }
        public int Bellek { get; set; }
        public int Hdd { get; set; }
        public int Ssd { get; set; }
        public bool EthernetVarMi { get; set; }
        public bool WifiVarMi { get; set; }

    }
}
