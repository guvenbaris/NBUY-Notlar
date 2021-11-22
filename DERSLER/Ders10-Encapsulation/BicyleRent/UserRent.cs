using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.BicyleRent
{
   public class UserRent
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string  Telefon{ get; set; }

        public void UserInfo()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine($"Kullanıcı Id : {Id}, İsim Soyisim : {AdSoyad}, Telefon {Telefon}");
        }
    }
}
