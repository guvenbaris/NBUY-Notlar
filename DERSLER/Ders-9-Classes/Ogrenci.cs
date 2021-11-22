using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Classes
{
    public class Ogrenci
    {
        public long tcKimlikN;
        public string okulN;
        public string ad;
        public string soyad;
        public Ogretmen sinifOgretmeni;

        public Ogrenci()
        {
        }

        public Ogrenci(long tc, string okulN, string ad, string soyad, Ogretmen sinifOgretmeni)
        {
            this.tcKimlikN = tc;
            this.okulN = okulN;
            this.ad = ad;
            this.soyad = soyad;
            this.sinifOgretmeni = sinifOgretmeni;

        }
        public void SinifOgretmeniDegistir(Ogretmen ogretmen)
        {
            this.sinifOgretmeni = ogretmen;
        }
        public void BilgiYaz()
        {
            Console.WriteLine(this.tcKimlikN);
            Console.WriteLine(this.okulN);
            Console.WriteLine(this.ad);
            Console.WriteLine(this.soyad);
            Console.WriteLine(this.sinifOgretmeni.ad + " " + this.sinifOgretmeni.soyad);
        }
    }
}
