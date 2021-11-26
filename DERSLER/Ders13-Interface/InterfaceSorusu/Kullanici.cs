using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.InterfaceSorusu
{
    class Kullanici
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        public List<string> GetKullanici()
        {
            List<string> kullanicilar = new List<string>();
            kullanicilar.Add(this.AdSoyad);
            kullanicilar.Add(this.Eposta);
            kullanicilar.Add(this.Telefon);

            return kullanicilar;
        }
    }
}
