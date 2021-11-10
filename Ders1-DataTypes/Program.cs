using System;

namespace Ders1_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte sayi = -45;
            //byte bSayiMaks = byte.MaxValue;
            //byte bSayiMin = byte.MinValue;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}",bSayiMin,bSayiMaks);

            //byte shortSayiMax = byte.MaxValue;
            //byte shortSayiMin = byte.MinValue;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}", shortSayiMin, shortSayiMax);

            //int sayiMax = byte.MaxValue;
            //int sayiMin = byte.MinValue;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}", sayiMin,sayiMax);

            //long lSayiMax = byte.MaxValue;
            //long lSayiMin = byte.MinValue;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}", lSayiMin, lSayiMax);

            //float floatSayiMax = byte.MaxValue;
            //float floatSayiMin = byte.MinValue;
            //float floatSayi = 3.14f;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}", floatSayiMin, floatSayiMax);

            //double dSayiMax = byte.MaxValue;
            //double dSayiMin = byte.MinValue;

            //Console.WriteLine("MinSayi : {0}, MaxSayi :  {1}", dSayiMin, dSayiMax);

            //var s1 = 55;
            //var s2 = 34.52;
            //var s3 = "Barış";

            //Console.WriteLine("s1 değişkeninin tipi:{0}", s1.GetType());
            //Console.WriteLine("s1 değişkeninin tipi:{0}", s2.GetType());
            //Console.WriteLine("s1 değişkeninin tipi:{0}", s3.GetType());

            //bool control = true;


            // Kullanıcıdan alınan Ad-Soyad Email Parola ekrana basılması
            //Console.Write("Ad Soyad Giriniz : ");
            //string nameSurname = Console.ReadLine();
            //Console.Write("Email Giriniz : ");
            //string email = Console.ReadLine();
            //Console.Write("Parola Giriniz : ");
            //string parola = Console.ReadLine();
            //Console.WriteLine("******************");
            //Console.WriteLine("Ad-Soyad : {0},Email : {1}, Password : {2}",nameSurname,email,parola);
            //Console.WriteLine("******************");
            //Console.WriteLine($"Ad-Soyad : {nameSurname} \n Email : {email} \n Password : {parola}");


            // Referans Tipi Veriler
            // Ram'de ki adres bilgisini tutar
            // Tüm tiplerdeki değerleri alabilir
            object genelDegisken = 999;
            genelDegisken = 23.23F;
            genelDegisken = 3.14D;
            genelDegisken = "Merhaba Dünya";
            Console.WriteLine(genelDegisken);

            String referansTip = "Bu değişken String sınıfından türetilmiştir.";
            string degerTip = "Bu değişken String sınıfından türetilmiş string değer veri tipindedir.";


            Console.WriteLine(referansTip.GetType());
            Console.WriteLine(degerTip.GetTypeCode());
            Console.ReadKey();


        }
    }
}
