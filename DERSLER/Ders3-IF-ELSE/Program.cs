using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Ders3_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool kosul = true;

            //if (kosul == true)
            //{
            //    Console.WriteLine("Koşul sağlanıyorsa (true ise) bu kod bloğu çalışır.");
            //}
            //else
            //{
            //    Console.WriteLine("Koşul sağlanmıyorsa bu blok çalışır");
            //}

            //Girilen sayının 5'ten küçük veya büyük olma durumu ? 
            //Console.Write("Sayı giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 5)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine(Math.Pow(number,2));
            //}

            //İki sayı karşılaştırma
            //Console.Write("1. Sayı giriniz : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayı giriniz : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 > number2)
            //{
            //    Console.WriteLine("1.Sayı büyüktür : ", number1);
            //}
            //if (number2 > number1)
            //{
            //    Console.WriteLine("2.Sayı büyüktür : ", number2);
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayılar eşittir.");
            //}

            // Girilen 3 sayıdan 100den küçük olanları topla 
            //            Console.Write("1. Sayı giriniz : ");
            //            int number1 = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("2. Sayı giriniz : ");
            //            int number2 = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("3. Sayı giriniz : ");
            //            int number3 = Convert.ToInt32(Console.ReadLine());

            //            int toplam = 0;
            //            if (number1 < 100)
            //                toplam += number1;

            //            if (number2 < 100)
            //            {
            //                toplam += number2;
            //            }

            //            if (number3 < 100)
            //            {
            //                toplam += number3;
            //;           }
            //            Console.WriteLine("100 den küçük olan sayıların toplamı {0}",toplam);
            // Not' u harfe çeviren programı yazınız 
            //Console.Write("Notunuzu Giriniz : ");
            //int not = Convert.ToInt32(Console.ReadLine());
            //if(0<= not & not <= 49)
            //{
            //    Console.WriteLine("F");
            //    Console.WriteLine("Kaldınız tebrikler.");
            //}
            //else if (50 <= not & not <= 64)
            //{
            //    Console.WriteLine("D");
            //}
            //else if (65 <= not & not <= 69)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (70 <= not & not <= 84)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (85 <= not & not <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir not giriniz");
            //}

            //Console.Write("1.Sayıyı Giriniz : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İşlem giriniz(topla,cikar,carp,bol) : ");
            //string islem = Console.ReadLine();

            //int result = 0;
            //if (islem == "topla")
            //{
            //    result = sayi1 + sayi2;
            //    Console.WriteLine("Toplama işlemi sonucu {0}",result);
            //}
            //else if (islem == "carp")
            //{
            //    result = sayi1 * sayi2;
            //    Console.WriteLine("Carpma işlemi sonucu {0}", result);
            //}
            //else if (islem == "cikar")
            //{
            //    if (sayi1 > sayi2)
            //    {
            //        result = sayi1 - sayi2;
            //        Console.WriteLine("Çıkarma işlemi sonucu {0}", result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Çıkarma işlemi gerçekleştirilemiyor");
            //    }

            //}
            //else if (islem == "bol")
            //{
            //    if (sayi2 != 0 & sayi1 > sayi2)
            //    {
            //        float bolme = sayi1 / sayi2;
            //        Console.WriteLine("Bölme işlemi sonucu {0}", bolme);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bölme işlemi için sayi2 0 dan farklı olmalı");
            //    }
            //}

            //Console.Write("Sayı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine(sayi);
            //}
            //else
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        int kalan = sayi / 3;
            //        Console.WriteLine($"Sayının 3 ün {kalan} katıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 3 ün katı değildir");
            //    }
            //}

            //int negatifToplam = 0;
            //int positiveSum = 0;
            //int count = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Sayi giriniz :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0)
            //    {
            //        negatifToplam += sayi;
            //        count += 1;
            //    }
            //    else
            //    {
            //        positiveSum += sayi;

            //    }
            //}
            //Console.WriteLine("Negatif toplamlar : {0}, Pozitif Toplamlar {1}",negatifToplam,positiveSum);
            //Console.WriteLine("{0} negatif ,{1} pozitif sayı girildi.",count,5-count);

            //Console.Write("Bir sayi giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int result = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    result =  result * i;
            //}
            //Console.WriteLine(result);

            //Console.Write("Taban sayisini giriniz : ");
            //int tabanSayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üst sayisini giriniz : ");
            //int usSayi = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < usSayi; i++)
            //{
            //    result = result * tabanSayi;
            //}
            //Console.WriteLine(result);

            //Klavyeden girilen sayı 0-100 arasında değilse tekrar isteyen programı yazınız 
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("Sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0 && sayi <= 100)
                {
                    Console.WriteLine(sayi);
                    break;
                }
            }

            // Yukarıdaki şekilde 3 sayı alıp bunların aritmetik ortalamasını bulan programı yaz.
            int count = 0;
            int sonuc = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("Sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0 && sayi <= 100)
                {
                    count += 1;
                    sonuc += sayi;
                    if (count == 3)
                    {
                        Console.WriteLine(sonuc/3);
                        break;
                    }
                    
                }
            }
        }
    }
}
