using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Classes.EmlatSitesiOdev
{
   public class User
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public User UserEditing(User user)
        {
            User _user = new User
            {
                Address = user.Address,
                NameSurname = user.NameSurname,
                Telephone = user.Telephone,
                Id = user.Id
            };
            return _user;
        }

        public void UserInfo()
        {
            Console.WriteLine($"Kullanıcı Id :{Id}, Kullanıcı Ad-Soyad : {NameSurname}, Kullanıcı Adresi : {Address}, " +
                              $"Kullanıcı Telefonu : {Telephone }");
        }
    }
}
