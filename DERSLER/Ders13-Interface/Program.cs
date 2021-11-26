using System;
using Ders13_Interface.InterfaceSorusu;

namespace Ders13_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTest classTest = new ClassTest();
            //classTest.Marka = "BMW";
            //classTest.Model = "2016";
            //classTest.BilgiYaz();

            //ITest test = new ClassTest();
            //test.Marka = "Audi";
            //test.Model = "2020";
            //test.BilgiYaz();
            Kullanici kullanici = new Kullanici
            {
                AdSoyad = "Kamil",
                Telefon = "0241478",
                Eposta = "gvnbrs54@gmail.com"
            };
            Sigorta sigorta = new Sigorta
            {
                BitisTarihi = DateTime.Now
            };
            Araba araba = new Araba
            {
                IlanNo = "0214566",
                _sigorta = sigorta,
                IlanTarihi = new DateTime(1993, 05, 12),
                Marka = "BMW",
                Model = "320d",
                MotorHacmi = 40.0f,
                _Kullanici = kullanici
            };
            araba.SigortaYap(DateTime.Now);
        }
    }
}
