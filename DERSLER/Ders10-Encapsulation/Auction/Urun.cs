using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.Auction
{
   public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        private DateTime StartTime { get; set; }
        public int AdvertisementTime { get; set; }

        public List<Offer> Offers = new List<Offer>();

        public void Basla()
        {
            StartTime = DateTime.Now;
        }

        public bool TeklifKontrol(Offer offer)
        {
            if (StartTime.Millisecond <= AdvertisementTime)
            {
                Offers.Add(offer);
                return true;
            }
            else
            {
                Console.WriteLine("Müzakere bitmiştir.");
                return false;
            }
        }

        public void Sonuclandir()
        {
            foreach (var offer in Offers)
            {
                Console.WriteLine($"Ürün Adı : {offer.urun.UrunAdi}, Ürün fiyatı : {offer.price}, Kullanıcı : {offer.user.adSoyad}");
            }
        }
    }
}
