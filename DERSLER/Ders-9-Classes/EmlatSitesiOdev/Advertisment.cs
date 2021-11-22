using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Classes.EmlatSitesiOdev
{
    public class Advertisment
    {
        public int Id { get; set; }
        public DateTime AdvertismentDate { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public bool RentOrSellStatus { get; set; } //true => kiralama, false=>satma
        public double Price { get; set; }

        public void AdvertisementInfo()
        {
            string status;
            status = RentOrSellStatus ? "Kiralık" : "Satılık";
            Console.WriteLine($"İlan Başlığı : {Title}, İlan Tarihi : {AdvertismentDate}, Fiyatı : {Price}, " +
                              $"Kiralama veya Satma Durumu : {status}, Açıklama : {Explanation},");
        }
        public Advertisment AdvertismentUpdate(Advertisment advertisement)
        {
            Advertisment _advertisment = new Advertisment
            {
                 AdvertismentDate = advertisement.AdvertismentDate,
                 RentOrSellStatus = advertisement.RentOrSellStatus,
                 Explanation = advertisement.Explanation,
                 Price = advertisement.Price,
                 Title = advertisement.Title
            };
            
            return _advertisment;
        }
    }
}
