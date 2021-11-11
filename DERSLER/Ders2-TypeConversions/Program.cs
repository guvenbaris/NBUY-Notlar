using System;

namespace Ders2_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Tür Dönüşümü 
            //küçük tür büyük türe otomatik olarak dönüştürülür.
            //byte byteSayi = 58;
            //int intSayi = byteSayi;

            //short shortSayi = 34;
            //long longSayi = shortSayi;

            //float floatSayi = 29.45f;
            //double doubleSayi = floatSayi;
            //Console.WriteLine("Sorunsuz Çalıştı");

            //Kasıtlı Tür Dönüşümü
            //int intSayi = 254;
            //byte byteSayi = (byte)intSayi;
            //// int sayi 255 den büyük olursa 32 bitlik değerin sadece son 8 biti alınacağından veri kaybı olur.
            //Console.WriteLine("Sorunsuz Çalıştı");

            //double doubleSayi = 45000.78D;
            //float floatSayi = (float) doubleSayi;

            //float fSayi = 77.345f;
            //int iSayi = (int) fSayi;
            //Console.WriteLine($"fSayi = {fSayi} iSayi = {iSayi}");

            // Veri kaybı olur
            //int intSayi = 256;
            //byte byteSayi = (byte) intSayi; // En sağdaki 8 biti alır
            //Console.WriteLine($"byte Sayi :  {byteSayi}");

            //Yukarıda ki veri kaybını önlemek 
            // Veri kaybı durumunda hata var 
            //checked
            //{
            //    int intSayi = 256;
            //    byte byteSayi = (byte)intSayi; // En sağdaki 8 biti alır
            //    Console.WriteLine($"byte Sayi :  {byteSayi}");
            //    unchecked
            //    {
            //        // Burada hata vermeden çalışır veri kaybına göz yumar.
            //    }
            //}

            //// Convert Sınıfı Metodları ile Tür Dönüşümü 
            //double dSayi = 678.456d;
            //string sSayi = Convert.ToString(dSayi);
            //Console.WriteLine($"sSayi : {sSayi.GetType()}");

            //string postaKodu = "34460";
            //int postaKoduInt = Convert.ToInt32(postaKodu);
            //Console.WriteLine($"postaKoduInt tipi{postaKoduInt.GetType()}");

            //int s1 = 10;
            //int s2 = 15;
            //int toplam = s1 + s2;
            //SORU: Klavyeden girilen iki sayının toplamını ekrana yazdıran programı yazınız. ?
            //Console.Write("Birinci sayıyı giriniz : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sonuc : {0}",sayi1+sayi2);

            // SORU: Klavyeden fahrenayt olarak girilen sıcaklık bilgisini Santigrat cinsine
            // çevirip aşağıdaki formatta ekrana yazdıran prog.

            //Console.Write("Sıcaklık değerini giriniz : ");
            //string sfahrenayt =  Console.ReadLine();
            //double fahrenayt = Convert.ToDouble(sfahrenayt);
            //double derece = Math.Round((fahrenayt - 32) / 1.8,3);
            //Console.WriteLine("{0} Fahrenayt => {1} Santigrat derecedir",sfahrenayt,derece);
            
            // Parse Metodu ile tip dönüşümü 
            //parse metodu string ifadeleri sayısal değerlere dönüştürür.
            //int degisken = int.Parse("365");
            //double degisken2 = double.Parse("34");
            //short degisken3 = short.Parse("4321");


            //Boxing & Unboxing 
            // object veri tipi tüm tiplerin üst tipidir.
            //kasıtsız
            //int limit = 120;
            //object kutu = limit;

            //casting ile boxing 
            //object kutu = (object) limit;

            //Unboxing 
            // 1.Kural: Unboxing uygulanacak nesneye daha önceden boxing uygulanmış olmalıdır.
            //2.Kural Nesne içerisinde ki değer hedef tipte olmalıdır. 
            //float ondalikliSayi = 94.32f;
            //boxing 
            //object nesne = ondalikliSayi;

            //unboxing
            //ondalikliSayi = (float) nesne;

            Console.Write("S1 = ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("S2 = ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            
            Console.WriteLine("İki sayının toplamının karesi : {0}",Math.Pow(toplam,2));

        }
    }
}
