using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım.Personel
{
    enum Bolumler
    {
        Muhasebe,
        Yazilim_Birimi, 
        IT_Birimi, 
        IK, 
        Satın_Alma, 
        Hukuk, 
        Satis
    }
    class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public Bolumler _Bolum { get; set; }
        public int Yas { get; set; }

        public Personel()
        {
            
        }
        public Personel(int id, string adSoyad, Bolumler bolum, int yas)
        {
            Id = id;
            AdSoyad = adSoyad;
            _Bolum = bolum;
            Yas = yas;
        }

        public void BilgiYaz()
        {
            Console.WriteLine($"Id : {Id}, Adı-Soyadı : {AdSoyad}, Bölüm : {_Bolum}, Yaş :{Yas}");
        }
    }
}
