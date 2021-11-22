using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Classes
{
   public class Ogretmen
    {
        public int ID;
        public string ad;
        public string soyad;
        public List<Ogrenci> ogrenciler; // List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public Ogretmen()
        {
            this.ogrenciler = new List<Ogrenci>(); // Nesne oluşturulduğu anda RAM'de Liste için alan açılır. Liste oluşturulur.
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Öğretmen Adı: {this.ad}");
            Console.WriteLine($"Öğretmen Soyadı: {this.soyad}");
        }
        public void OgrenciListele()
        {
            Console.WriteLine($"***** {this.ad} {this.soyad} öğretmenin öğrencileri *****");
            foreach (var item in this.ogrenciler) // item Ogrenci sınıfı nesnesidir.
            {
                Console.WriteLine(item.ad + " " + item.soyad);
            }
            Console.WriteLine("************************************");
        }
    }
}
