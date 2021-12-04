using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.Auction
{
   public class Offer
    {
        public int Id { get; set; }
        public User user { get; set; }

        public Urun urun { get; set; }
        public int price { get; set; }

    }
}
