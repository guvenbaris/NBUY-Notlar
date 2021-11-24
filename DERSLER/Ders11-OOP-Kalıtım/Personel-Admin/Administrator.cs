using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Personel
{
    class Administrator :Personel
    {
        public int AltPersonelSayisi { get; set; }

        public Administrator(int altPersonelSayisi)
        {
            AltPersonelSayisi = altPersonelSayisi;
        }
        public Administrator()
        {
            
        }

       new public void BilgiYaz()
        {
            Console.WriteLine($"Alt Personel Sayisi : {AltPersonelSayisi}, Id : {Id}, Adı-Soyadı : {AdSoyad}, Bölüm : {_Bolum}, Yaş :{Yas}");
        }
    }
}
