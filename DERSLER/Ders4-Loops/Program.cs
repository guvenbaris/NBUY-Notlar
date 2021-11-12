using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Ders4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi += 1;
            //}

            //Console.Write("Bir sayi giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 1)
            //{
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Write("Mesajınızı yazınız (Çıkmak için ÇIK yazınız) : ");
            //string yazi = Console.ReadLine();

            //while (yazi !="CIK")
            //{
            //    Console.WriteLine(yazi);
            //    Console.Write("Mesajınızı yazınız (Çıkmak için ÇIK yazınız) : ");
            //    yazi = Console.ReadLine();
            //}

            //Console.WriteLine("Program sonlandı!.");

            //Console.Write("Sayi giriniz (Bitirmek için bitir yazınız) : ");
            //string deger = Console.ReadLine();
            //var isNumeric = int.TryParse(deger, out _);
            //int toplam = 0;
            //int sayi = 0;

            //while (deger.ToLower() != "bitir")
            //{
            //    if (isNumeric == true)
            //    {
            //        sayi = Convert.ToInt32(deger);
            //        toplam += sayi;
            //    }
            //    Console.Write("Sayi giriniz (Bitirmek için bitir yazınız) : ");
            //    deger = Console.ReadLine();
            //    isNumeric = int.TryParse(deger, out _);
            //}
            //Console.WriteLine($"TOPLAM = {toplam}");


            //Console.Write("Sayi giriniz (Bitirmek için bitir yazınız) : ");
            //string deger = Console.ReadLine();
            //var isNumeric = int.TryParse(deger, out _);
            //int toplam = 0;
            //int sayi = 0;

            //while (deger.ToLower() != "bitir")
            //{

            //    sayi = Convert.ToInt32(deger);
            //    if (sayi % 5 == 0)
            //    {
            //        Console.WriteLine("5'in katı girildiği için çıkış yapıldı");
            //        deger = "bitir";
            //    }
            //    else 
            //    {
            //        toplam += (sayi * sayi);
            //        Console.Write("Sayi giriniz (Bitirmek için bitir yazınız) : ");
            //        deger = Console.ReadLine();
            //    }
            //}
            //Console.WriteLine($"TOPLAM = {toplam}");

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} çift sayıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} tek sayıdır.");
            //    }
            //}

            //while (true)
            //{
            //    Console.Write("Bir sayı giriniz : ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 5 == 0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    else if (sayi % 19 == 0)
            //    {
            //        Console.WriteLine("Game Over");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}

            //int sayi = 1;
            //while (sayi <= 10)
            //{
            //    if (sayi == 7)
            //    {
            //        sayi++;
            //        continue;
            //    }
            //    else if (sayi == 9)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi++;
            //}

            //string email ="network@akademi.net";
            //string parola = "nA123";
            
            //string ep, pa;
            //do
            //{
            //    Console.Write("Kullanıcı Adı Giriniz : ");
            //    ep = Console.ReadLine();
            //    Console.Write("Email adresinizi giriniz : ");
            //    pa = Console.ReadLine();


            //} while (ep != email || pa != parola);
            //{
            //}
            //Console.Write("Sayi : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < sayi; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Program sonlandı...");

            //Console.Write("Birinci sayı : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayı : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    for (int i = sayi1; i >= sayi2; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else if (sayi2 > sayi1)
            //{
            //    for (int i = sayi2; i >= sayi1; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("İki sayıt eşit olduğu için işlem gerçekleştirelemez...");
            //}

            int toplam = 0;
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ürün fiyatını giriniz : ");
                int fiyat = Convert.ToInt32(Console.ReadLine());
                toplam += fiyat;
                result = (int)( toplam * 1.18);
                Console.WriteLine("{0} kdvli fiyat {1}",fiyat,fiyat + (fiyat*0.18));
            }
            Console.WriteLine(result);









        }
    }
}
