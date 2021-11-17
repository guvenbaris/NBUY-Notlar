using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_Methods_Devam
{
    class Program
    {
        static List<object> personels = new List<object>() { 123456789, "Kamil", "beyoğlu", "054125745" };

        static List<long> tC = new List<long>();
        static List<string> adSoyad = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefon = new List<string>();
        static void Main(string[] args)
        {
            //Console.WriteLine(DortIslem(10, 16, "bol"));
            //float[] floatArrays = new float[] {3.14f,4.15f };
            //foreach (var floatArray in makeItDouble(floatArrays))
            //{
            //    Console.WriteLine(floatArray);
            //}
            //List<string> myLists = new List<string>();
            //myLists = CokYaz(5);
            //foreach (var myList in myLists)
            //{
            //    Console.WriteLine(myList);
            //}
            string deger = PersonelSearch(123456789);
            Console.WriteLine(deger);


        }
        static int DortIslem(int sayi1, int sayi2, string islem)
        {
            if (islem == "topla")
            {
                return Topla(sayi1, sayi2);
            }

            else if (islem == "cikar")
            {

                return Cikar(sayi1, sayi2);

            }
            else if (islem == "carp")
            {
                return Carp(sayi1, sayi2);
            }
            else
            {
                return Bol(sayi1, sayi2);
            }
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        static int Bol(int sayi1, int sayi2)
        {
            if (sayi2 != 0)
            {
                return sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Birinci verilen değer ikinci verilen değerden büyük olmak zorundadır.");
                return 0;
            }
        }
        static double[] makeItDouble(float[] floatArrays)
        {
            double[] makeDoubles = new double[floatArrays.Length];
            for (int i = 0; i < floatArrays.Length; i++)
            {

                makeDoubles[i] = Convert.ToDouble(floatArrays[i]);
            }
            return makeDoubles;
        }

        static string Yaz()
        {
            Console.Write("Birşeyler yaz : ");
            return Console.ReadLine();
        }

        static List<string> CokYaz(int tekrar)
        {
            List<string> myList = new List<string>();
            for (int i = 0; i < tekrar; i++)
            {
                myList.Add(Yaz());
            }
            return myList;
        }

        static bool PersonelAdd(long identityNumber, string nameSurname, string adress, string phoneNumber)
        {
            tC.Add(identityNumber);
            adSoyad.Add(nameSurname);
            adresler.Add(adress);
            telefon.Add(phoneNumber);
            return true;
        }
        static bool PersonelSil(long identityNumber)
        {
            int index = tC.IndexOf(identityNumber);
            if (index != -1)
            {
                tC.Remove(identityNumber);
                adSoyad.RemoveAt(index);
                adresler.RemoveAt(index);
                telefon.RemoveAt(index);

                return true;
            }

            return false;
        }
        static void PersonelUpdate(long identityNumber, string nameSurname, string adress, string phoneNumber)
        {
            int index = tC.IndexOf(identityNumber);

            if (tC.Contains(identityNumber))
            {
                if (nameSurname != "")
                {
                    adSoyad[index] = nameSurname;
                }
                else if (adress != "")
                {
                    adresler[index] = adress;
                }
                else if (phoneNumber != "")
                {
                    telefon[index] = phoneNumber;
                }

            }
        }
        static string PersonelSearch(long identityNumber = 0, string nameSurname = "", string adress = "", string phoneNumber = "")
        {
            string personel = "";
            int index = -1;
            if (nameSurname != "")
            {
                if (adSoyad.Contains(nameSurname))
                {
                    index = adSoyad.IndexOf(nameSurname);
                }
            }
            else if (identityNumber != 0)
            {
                if (tC.Contains(identityNumber))
                {
                    index = tC.IndexOf(identityNumber);
                }
            }
            else if (adress != "")
            {
                if (adresler.Contains(adress))
                {
                    index = adresler.IndexOf(adress);
                }

            }
            else if (phoneNumber != "")
            {
                if (telefon.Contains(phoneNumber))
                {
                    index = telefon.IndexOf(phoneNumber);
                }
            }
            if (index != -1)
            {
                personel += Convert.ToString(tC[index]) + " " + adSoyad[index] + " " + adresler[index] + " "+
                            telefon[index];
            }
            return personel;
        }
        static string PersonelYaz(List<long> TCler,List<string> nameSurname,List<string> adresler,List<string>telefonlar)
        {
            string personel = "";
            for (int i = 0; i < TCler.Count; i++)
            {
                personel = TCler[i] + " " + nameSurname[i] + " " + adresler[i] + " " + telefonlar[i] + " "+"/n";
            }
            return personel;
        }

    }
}
