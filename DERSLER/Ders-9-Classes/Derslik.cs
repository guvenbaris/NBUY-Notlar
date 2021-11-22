using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Classes
{
    public class Derslik
    {
        public int derslikN;
        public string adi;
        public int kapasite;
        public int kat;
        public Ogretmen ogretmen;
        public bool ogretmenAtamaKontrol(Ogretmen ogretmen)
        {
            bool kontrol = this.kapasite >= ogretmen.ogrenciler.Count();
            if (kontrol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ogretmenAta(Ogretmen ogretmen)
        {
            if (ogretmenAtamaKontrol(ogretmen))
            {
                this.ogretmen = ogretmen;
                return true;
            }
            return false;
        }

        public void BilgiYaz()
        {
            Console.WriteLine($"{this.adi} SINIFI BİLGİLERİ");
            Console.WriteLine($"Kapasitesi {this.kapasite}");
            Console.WriteLine($"Bulunduğu kat {this.kat}");
            Console.WriteLine($"Öğretmen : {ogretmen.ad} {ogretmen.soyad}");
        }

    }
    
}
