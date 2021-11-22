using System;
using Ders_9_Classes.EmlatSitesiOdev;

namespace Ders_9_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Advertisment advertisment = new Advertisment
            {
                Title = "Mazda",
                RentOrSellStatus = true,
                Explanation = "Nice car",
                Id = 1,
                AdvertismentDate = DateTime.Now,
                Price = 5000
            };

            Advertisment advertisment1 = new Advertisment
            {

                Title = "Honda",
                RentOrSellStatus = true,
                Explanation = "Nice car",
                Id = 1,
                AdvertismentDate = DateTime.Now,
                Price = 5000
            };

            Console.WriteLine(advertisment.AdvertismentUpdate(advertisment1).Title);
            advertisment1.AdvertisementInfo();


            //Araba araba = new Araba();
            //araba.Marka = "Mazda";
            //araba.Model = "6";
            //araba.BilgiYaz();
        }
    }
    //class Araba
    //{
    //    int id;
    //    public string Marka;
    //    public string Model;

    //    public void BilgiYaz()
    //    {
    //        Console.WriteLine($"{this.Marka} {this.Model} ");
    //    }
    //}

    //public class Student
    //{
    //    public int tcKimlikN;
    //    public int okulN;
    //    public string ad;
    //    public string soyad;
    //    public string sinifOgretmeni;

    //    public Student(int tcKimlikN, int okulN, string ad, string soyad, string sinifOgretmeni)
    //    {
    //        this.tcKimlikN = tcKimlikN;
    //        this.okulN = okulN;
    //        this.ad = ad;
    //        this.soyad = soyad;
    //        this.sinifOgretmeni = sinifOgretmeni;
    //    }
    //    public void SinifOgretmeniDegistir(string ogrtmen)
    //    {
    //        Console.WriteLine($"{ogrtmen}'i değiştirmek istiyor musunuz ? ");
    //    }

    //    public void BilgiYaz()
    //    {
    //        Console.WriteLine($"TC : {this.tcKimlikN} Okul No: {this.okulN}, ad : {this.ad}, soyad {this.soyad},Sınıf Öğretmeni {this.sinifOgretmeni}");
    //    }

    //}
}
