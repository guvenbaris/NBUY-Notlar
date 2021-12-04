using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Ders5_Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ////tip[] diziİsmi = new tip[boyut]
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////indis numaraları 0 dan başlar 1 er 1 er artarak devam eder.
            //Console.WriteLine($"rakamlar dizisinin ilk elemanı {rakamlar[0]}");
            //rakamlar[0] = 100;
            //rakamlar.SetValue(100, 0); //yukarıda ki işlemin alternatifidir.
            //Console.WriteLine($"rakamlar dizisinin ilk elemanı {rakamlar[0]}");

            //string[] cities = { "Adana",};
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            ////Kullanıcıdan alınan 10 isim bilgisini string bir diziye kaydedip daha sonra
            ////dizi elemanlarını ekrana yazdırın.

            //string[] cities = new string[] { };
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Şehir giriniz : ");
            //    string city = Console.ReadLine();
            //    cities[i] = city;
            //}
            //Console.WriteLine("******************");
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Random randomSayilar = new Random();

            //int[] sayilar = new int[] { };
            //for (int i = 0; i < 10; i++)
            //{
            //    sayilar[i] = randomSayilar.Next(0, 100);
            //}
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //int startIndex = 0;
            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 10, 30 };

            //int count = puanlar.Count(sayi => sayi == 10);

            //for (int i = 0; i < count; i++)
            //{
            //    startIndex = Array.IndexOf(puanlar, 10, startIndex);
            //    Console.WriteLine(startIndex);
            //    startIndex += 1;
            //}
            //int[,] matris = new int[5, 5];
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 4] = 30;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j]);
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i % 2 == 0 && (j == 0 || j == 4))
            //        {
            //            matris[i, j] = 2;
            //        }
            //        else if (i % 2 != 0 && (j == 0 || j == 4))
            //        {
            //            matris[i, j] = 1;
            //        }
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j]);
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == j)
            //        {
            //            matris[i, j] = 1;
            //        }

            //        if (i + j == 4)
            //        {
            //            matris[i, j] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int[,] matris = new int[2, 4];
            //int sayi;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Bir sayi giriniz : ");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //        matris[i, j] = sayi;
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matris = new int[2, 4];
            //int sayi;
            //int toplam = 0;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j != 3)
            //        {
            //            Console.Write("Bir sayi giriniz : ");
            //            sayi = Convert.ToInt32(Console.ReadLine());
            //            matris[i, j] = sayi;
            //        }

            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        toplam += matris[i, j];
            //    }
            //    matris[i, 3] = toplam;
            //    toplam = 0;
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matris[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //// 3 Boyutlu diziler
            //Random rnd = new Random();
            //int[,,] dizi = new int[2, 3, 3];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            dizi[i, j, k] = rnd.Next(0,1000);
            //        }
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write(dizi[i, j, k]+"  ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("************");
            //    Console.WriteLine("************");
            //}

            //List<int> myList = new List<int>();
            //myList.Add(1992);
            //myList.Add(1993);
            //myList.Add(1994);
            //myList.Add(1995);
            //myList.Insert(0,1988);

            //List<string> cities = new List<string>
            //{
            //    "İstanbul",
            //    "İzmir",
            //    "Manisa",
            //    "Van"
            //};

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //List<int> sayilar1 = new List<int>();
            //List<int> sayilar2 = new List<int>();

            //List<int> compareList = new List<int>();

            //Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    sayilar1.Add(random.Next(0,100));
            //    sayilar2.Add(random.Next(0, 100));
            //}

            //foreach (var sayi in sayilar2)
            //{
            //    if (!sayilar1.Contains(sayi))
            //    {
            //        compareList.Add(sayi);
            //    }
            //}

            //foreach (var sayi in sayilar1)
            //{
            //    if (!sayilar2.Contains(sayi))
            //    {
            //        compareList.Add(sayi);
            //    }
            //}

            //For-each e alternatif
            //for (int i = 0; i < sayilar1.Count; i++)
            //{
            //    if (!sayilar1.Contains(sayilar2[i]))
            //    {
            //        compareList.Add(sayilar2[i]);
            //    }
            //    if (!sayilar2.Contains(sayilar1[i]))
            //    {
            //        compareList.Add(sayilar1[i]);
            //    }
            //}

            //Console.WriteLine("Birinci listenin elemanları : ");
            //foreach (var sayi1 in sayilar1)
            //{
            //    Console.WriteLine($"Birici liste : {sayi1}");
            //}
            //Console.WriteLine("İkinci listenin elemanları : ");
            //foreach (var sayi2 in sayilar2)
            //{
            //    Console.WriteLine($"İkinci  liste : {sayi2}");
            //}
            //Console.WriteLine("Karşılaştırma sonucu listenin elemanları : ");
            //foreach (var sayiCompare in compareList)
            //{
            //    Console.WriteLine($"İkinci  liste : {sayiCompare}");
            //}

            //Random random = new Random();
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 15; i++)
            //{
            //    numbers.Add(random.Next(1,100));
            //}
            //Console.Write("Bir tahmin giriniz : ");
            //int prediction = Convert.ToInt32(Console.ReadLine());
            //if (numbers.Contains(prediction))
            //{
            //    Console.WriteLine($"Kazandınız girdiğiniz sayı mevcuttur indeksi {numbers.IndexOf(prediction)}");
            //}

            Random rnd = new Random();
            int rastGele = Convert.ToByte(rnd.Next(0, 255));
            Console.WriteLine($"Üretilen : {rastGele}/{Convert.ToChar(rastGele)}");

            int enYakinTahmin = 255;

            List<int> tahminler = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Tahmin:");
                string k = Console.ReadLine();
                Console.Write(k + " : ");
                int kInt = Convert.ToInt32(k[0]);
                tahminler.Add(kInt);
                Console.WriteLine(kInt);
            }

            foreach (var tahmin in tahminler)
            {
                if (tahmin == rastGele)
                {
                    Console.WriteLine("Tebrikler Buldunuz !");
                    char cTahmin = Convert.ToChar(tahmin);
                    enYakinTahmin = 0;
                    break;

                }
                else
                {
                    int fark = Math.Abs((rastGele - tahmin)); // Mutlak değer aldık.
                    if (fark < enYakinTahmin)
                        enYakinTahmin = (byte)fark;
                }
            }
            if (enYakinTahmin != 0)
                Console.WriteLine($"Malesef bulamadınız!\n Rastgele karakter/ ASCII kodu : {Convert.ToChar(rastGele)} /{rastGele} En yakın tahmininiz : {Convert.ToChar(enYakinTahmin)}/{enYakinTahmin} ");



        }
    }
}
