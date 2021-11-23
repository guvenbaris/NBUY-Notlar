using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Sahibinden
{
   public enum Kategori
    {
        Laptop,
        Masaüstü,
        TemizlikUrunleri
    }
    public class Ilan
    {
        public string IlanNo { get; set; }
        public string Baslik { get; set; }
        public DateTime IlanTarihi { get; set; }
        public double Price { get; set; }
        public Kategori _Kategori { get; set; }
        public Kullanici _kullanici { get; set; }

        public void BilgiYaz()
        {
            Console.WriteLine($" İlan No : {IlanNo},İlan Baslik :{Baslik},İlan Tarihi :{IlanTarihi},Kategori : {_Kategori},Fiyat :{Price},Satıcı : {_kullanici.Telefon}");

        }
        public double IndirimYap(int yuzde)
        {
            return (Price - (Price * yuzde) / 100);
        }
    }
}
