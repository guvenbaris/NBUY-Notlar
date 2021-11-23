using System;
using Ders11_OOP_Kalıtım.Personel;
using Ders11_OOP_Kalıtım.Sahibinden;

namespace Ders11_OOP_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanici kullanici = new Kullanici
            //{
            //    Id = 1,
            //    AdSoyad = "Kamil Atlar",
            //    Telefon = "0542 542 42 00"
            //};
            //Bilgisayar bilgisayar = new Bilgisayar()
            //{
            //    Bellek = 16,
            //    Hdd = 1000,
            //    Islemci = "intel core i7",
            //    EthernetVarMi = true,
            //    Marka = "Monster",
            //    Ssd = 512,
            //    WifiVarMi = true,

            //};
            //Masaustu masaustu = new Masaustu
            //{
            //    _Kasatipi = Kasatipi.Dikey,
            //    MonitorVarMi = false,
            //    Bellek = 16,
            //    Hdd = 1000,
            //    Islemci = "intel core i7",
            //    EthernetVarMi = true,
            //    Marka = "Monster",
            //    Ssd = 512,
            //    WifiVarMi = true,
            //    _kullanici = kullanici,
            //    IlanNo = "012412412",
            //    Price = 5000,
            //    _Kategori = Kategori.Laptop,
            //    Baslik = "Bizde Ucuz Bizde",
            //    IlanTarihi = DateTime.Now,

            //};
            //Dizüstü dizüstü = new Dizüstü
            //{
            //    EkranBoyutu = "16inch",
            //    Agirlik = 1600,
            //    Bellek = 16,
            //    Hdd = 1000,
            //    Islemci = "intel core i7",
            //    EthernetVarMi = true,
            //    Marka = "Monster",
            //    Ssd = 512,
            //    WifiVarMi = true,
            //    _kullanici = kullanici,
            //    IlanNo = "012412412",
            //    Price = 5000,
            //    _Kategori = Kategori.Laptop,
            //    Baslik = "Bizde Ucuz Bizde",
            //    IlanTarihi = DateTime.Now,

            //};

            //Console.WriteLine("******************************");
            //masaustu.BilgiYaz();
            //Console.WriteLine("******************************");
            //dizüstü.BilgiYaz();
            //Console.WriteLine("******************************");
            //bilgisayar.BilgiYaz();

            Personel.Personel personel = new Personel.Personel
            {
                AdSoyad = "Kamil Atlar",
                Id = 1,
                Yas = 25,
                _Bolum = Bolumler.IT_Birimi,
            };
           

            Administrator administrator = new Administrator
            {
                AdSoyad = "Muzaffer",
                Id = 2,
                Yas = 28,
                _Bolum = Bolumler.Yazilim_Birimi,
                AltPersonelSayisi = 100
            };
            personel.BilgiYaz();
            Console.WriteLine("**************");
            administrator.BilgiYaz();


        }
    }
}
