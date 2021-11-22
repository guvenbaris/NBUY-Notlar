using System;
using System.Threading;
using Ders10_Encapsulation.BicyleRent;

namespace Ders10_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //User u1 = new User();
            //u1.setAdSoyad("Kamil Atlar");
            //Console.WriteLine(u1.getAdSoyad());

            Bicyle bicyle = new Bicyle
            {
                Id = 1,
                JantBoyutu = 20,
                Marka = "Falcon",
                VitesSayisi = 21
            };
            UserRent userRent = new UserRent
            {
                Id = 1,
                AdSoyad = "Melih",
                Telefon = "0542 542 00 00"
            };
            RentBicyle rentBicyle = new RentBicyle
            {
                Id = 1,
                UserId = userRent.Id,
                BicyleId = bicyle.Id,
                RentTime = 60,
                Price = 25,
                RentStartTime = DateTime.Now,
            };
            bicyle.BicyleInfo();
            Console.WriteLine("**************************************");
            userRent.UserInfo();
            Console.WriteLine("**************************************");
            rentBicyle.RentStart();
            Thread.Sleep(5000);
            rentBicyle.RentFinish();
            rentBicyle.PriceCalculate();
            


        }
    }
}
