using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Ders6_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //MerhabaDunya();
            //Console.WriteLine(Topla(5, 6));
            //ShowOnTheScreen("Merhaba");ü

            //Console.WriteLine(TakeSquare(5));
            //Console.WriteLine(Kdv(100,"gıda"));
            //int sayi = SayiGir();
            //Console.WriteLine(sayi);
            //Console.WriteLine(Factorial(5));
            //Console.WriteLine(CheckIfPrime(12));
            //int[] rastgele = Random10();    
            //foreach (var item in rastgele)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] sayilar = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            ////ArrayElements(sayilar);
            //;
            //foreach (var sayi in TekSayilar(sayilar))
            //{
            //    Console.WriteLine(sayi);
            //}

            //List<int> squares = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //foreach (var sayi in TakeSquare(squares))
            //{
            //    Console.WriteLine(sayi);
            //}

            Console.WriteLine(FindBigNumber(15, 25));
            foreach (var number in TakeNumberFromUser())
            {
                Console.WriteLine(number);
            }

        }

        static void MerhabaDunya()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        static void ShowOnTheScreen(string key)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(key);   
            }
        }

        static int TakeSquare(int sayi)
        {
            return sayi * sayi;
        }

        static double Kdv(double fiyat,string urunTipi)
        {
            if (urunTipi.ToLower() == "gıda")
            {
                return fiyat * 1.08;
            }

            else if (urunTipi.ToLower() =="egitim")
            {
                return fiyat * 1.05;
            }
            else
            {
                return fiyat * 1.18;
            }
        }

        static int SayiGir()
        {
            Console.Write("Sayi giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }

        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        static double Factorial(double number)
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static bool CheckIfPrime(int sayi)
        {
            if (sayi == 2)
            {
                return true;
            }
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] Random10()
        {
            int[] sayiDizisi = new int[]{};
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayiDizisi[i] = random.Next(0, 100);
            }

            return sayiDizisi;
        }

        static void ArrayElements(int[] sayilar)
        {
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
           
        }

        static int[] TekSayilar(int[] sayilar)
        {
            int[] tekSayilar = new int[sayilar.Length];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 != 0)
                {
                    tekSayilar[i] = sayilar[i];
                }
            }
            return tekSayilar;

        }

        static int FindBigNumber(int sayi1,int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else if (sayi2 > sayi1)
            {
                return sayi2;
            }
            else
            {
                return sayi1;
            }
        }
        static int FindBigNumber3(int sayi1, int sayi2,int sayi3)
        {
           int buyukSayi =  FindBigNumber(sayi1, sayi2);
           if (buyukSayi > sayi3)
           {
               return buyukSayi;
           }
           else
           {
               return sayi3;
           }
        }

        static List<int> TakeSquare(List<int> sayilar)
        {
            List<int> mySquares = new List<int>();
            int squaredSayi;
            foreach (var sayi in sayilar)
            {
               squaredSayi =  (int)Math.Pow(sayi, 2);
               mySquares.Add(squaredSayi);
            }

            return mySquares;
        }

        static List<int> TakeNumberFromUser()
        {
            int sayi;
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }

            return sayilar;
        }


    }
}
