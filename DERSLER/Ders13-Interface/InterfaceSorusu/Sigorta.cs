using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.InterfaceSorusu
{
    class Sigorta
    {
        public DateTime BitisTarihi { get; set; }

        private string SigortaNo { get; set; }

        private static int sayac = 1;

        public Sigorta()
        {

            sayac++;
        }

        public void SigortaGuncelle()
        {
            this.BitisTarihi = DateTime.Now.AddYears(1);
            string myString = "";

            myString =  Convert.ToString(BitisTarihi.DayOfYear) +"_"+ Convert.ToString(sayac);

            Console.WriteLine($"Sigorta yapıldı sigorta numarası : {myString}, Bitiş Tarihi : {BitisTarihi}");

        }
    }
}
