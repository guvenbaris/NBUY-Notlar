using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation
{
    class User
    {
        public int Id;
        public string adSoyad;
        public string telephone;
        public string address;

        public void setAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public string getAdSoyad()
        {
            return this.adSoyad;
        }
    }
}
