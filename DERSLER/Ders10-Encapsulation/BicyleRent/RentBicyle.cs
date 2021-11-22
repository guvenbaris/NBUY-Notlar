using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.BicyleRent
{
    public class RentBicyle
    {
        public int Id { get; set; }
        public int BicyleId { get; set; }
        public int UserId { get; set; }
        public DateTime RentStartTime { get; set; }
        public int RentTime { get; set; }
        public DateTime RentFinishTime { get; }
        public double Price { get; set; }

        public void RentStart()
        {
            this.RentStartTime = DateTime.Now;
            Console.WriteLine("Kiralama başlangıç zamanı : {0}",this.RentStartTime);
        }

        public void RentFinish()
        {
            Console.WriteLine("Kiralama bitiş zamanı : {0}",RentStartTime.AddMinutes(this.RentTime));
        }

        public double PriceCalculate()
        {
            Console.WriteLine("Toplam ödenmesi gereken ücret tutarı : {0}",this.RentTime*60*30);
            return this.RentTime * this.Price;
        }
    }
}
