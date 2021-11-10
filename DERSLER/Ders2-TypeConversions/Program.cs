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
            Console.Write("Birinci sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuc : {0}",sayi1+sayi2);

            // SORU: Klavyeden fahrenayt olarak girilen sıcaklık bilgisini Santigrat cinsine
            // çevirip aşağıdaki formatta ekrana yazdıran prog.

            Console.Write("Sıcaklık değerini giriniz : ");
            string sfahrenayt =  Console.ReadLine();
            double fahrenayt = Convert.ToDouble(sfahrenayt);
            double derece = Math.Round((fahrenayt - 32) / 1.8,3);
            Console.WriteLine("{0} Fahrenayt => {1} Santigrat derecedir",sfahrenayt,derece);



        }
    }
}
