using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Dersler_Tekrar_1_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            //***************************************//
            //            1.Gün Tekrar              //
            //*************************************//
            // DEĞİŞKENLER
            bool bit = true;
            sbyte sayi = SByte.MinValue;
            byte sayi1 = Byte.MaxValue;
            int sayi2 = Int32.MaxValue;
            long sayi3 = long.MaxValue;
            float sayi4 = float.MaxValue;
            double sayi5 = double.MaxValue;

            //var değişkeni ilk atanan değerin tipinde veri bekler
            var s1 = 55;

            //Referans tipinde ki veriler
            //Ram'de ki adres bilgisini tutar
            //Tüm tiplerdeki değerleri alabilir
            object genelDegisken = 999;
            genelDegisken = 23.23F;
            genelDegisken = 3.14D;
            genelDegisken = "Merhaba Dünya";
            String referansTip = "Bu değişken String sınıfından türetilmiştir";
            string degerTip = "Bu değişken String sınıfından türetilmiş string değer veri tipindedir";

            //Console.WriteLine(referansTip.GetType());
            //Console.WriteLine(degerTip.GetTypeCode());
            //Console.WriteLine(genelDegisken);

            //***************************************//
            //            2.Gün Tekrar              //
            //*************************************//
            //OPERATÖRLER
            int a, b, c, d, sonuc1, sonuc2, sonuc3, toplam;
            a = 5;
            b = 10;
            c = 20;
            d = 30;

            sonuc1 = a * b / c + d;
            sonuc2 = a * (b / c) + d;
            sonuc3 = a * b / (c + d);

            //Console.WriteLine(sonuc1);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);

            //***************************************//
            //            3.Gün Tekrar              //
            //*************************************//
            // TÜR DÖNÜŞÜMLERİ
            // Bilinçsiz Tür Dönüşümü 
            //---küçük tür büyük türe otomatik olarak dönüşebilir.
            byte byteSayi = 58;
            int intNumber = byteSayi;

            short shortSayi = 34;
            long longSayi = shortSayi;

            float floatSayi = 29.45f;
            double doubleSayi = floatSayi;

            //Console.WriteLine(intNumber);
            //Console.WriteLine(longSayi);
            //Console.WriteLine(doubleSayi);

            //Kasıtlı Tür Dönüşümü
            int intSayi = 254;
            byte byteSayi1 = (byte) intSayi;
            // NOT : int sayi 255 den büyük olursa 32 bitlik değerin sadece son 8 biti alınacağından veri kaybı olur.
            double doubleSayi1 = 45000.78D;
            float floatSayi1 = (float)doubleSayi1;

            float floatSayi2 = 77.345f;
            int iSayi = (int) floatSayi2;
            //Console.WriteLine($"fSayi = {floatSayi2} iSayi = {iSayi}");

            //Convert Sınıfı Metodları ile Tür Dönüşümü
            double dSayi = 678.456d;
            string sSayi = Convert.ToString(dSayi);

            //Console.WriteLine($"sSayi : {sSayi}");
            //Console.WriteLine($"sSayi : {sSayi.GetType()}");

            //Parse Metodu ile tip dönüşümü 
            //parse metodu string ifadeleri sayısal değerlere dönüştürür
            int degisken = int.Parse("365");
            double degisken2 = double.Parse("34");
            short Sayi = 0;
            bool degisken3 = short.TryParse("20", out Sayi); // Dönüş başarılı ise true döner

            //Console.WriteLine(degisken3);

            //Boxing & Unboxing
            //object veri tipi tüm tiplerin üst tipidir 
            int limit = 120;
            object box = limit;

            // casting ile boxing 
            object kutu = (object) limit;

            //Unboxing 
            // 1.Kural: Unboxing uygulanacak nesneye daha önceden boxing uygulanmış olmalıdır.
            //2.Kural Nesne içerisinde ki değer hedef tipte olmalıdır. 
            float ondalikliSayi = 94.32f;
            object nesne = ondalikliSayi; //boxing
            ondalikliSayi = (float) nesne; //unboxing

            //Console.WriteLine($"box : {box}, kutu : {kutu}");
            //Console.WriteLine($"nesne : {nesne},ondalikliSayi : {ondalikliSayi}");

            //***************************************//
            //            4.Gün Tekrar              //
            //*************************************//
            //IF-ELSE ŞART BLOKLARI
            //bool kosul = Convert.ToBoolean(Console.ReadLine()); // Gelen bilgiye göre true ya da false olabilir kosul
            bool kosul = true;
            if (kosul == true)
            {
                //Console.WriteLine("Koşul sağlanıyorsa (true ise) bu kod bloğu çalışır.");
            }
            else
            {
                //Console.WriteLine("Koşul sağlanmıyorsa bu blok çalışır.");
            }

            //Example : Girilen sayının 5'ten küçük veya büyük olma durumu. Büyük ise ekrana sayıyı eğer küçükse ekrana karesini yazan program ? 
            //Console.WriteLine("Sayı Giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            int number = 6;
            if (number > 5)
            {
                //Console.WriteLine(number);
            }
            else
            {
                //Console.WriteLine(Math.Pow(number,2));
            }

            //***************************************//
            //            5.Gün Tekrar              //
            //*************************************//
            //LOOPS 

            //while Döngüsü 
            int number1 = 1;
            while (number1 <= 10) // Şart sağlandıkça döngü dönmeye devam eder.
            {
                //Console.WriteLine(sayi);
                number1 += 1;
            }

            //do-while Döngüsü 
            string email = "gvnbrs54@gmail.com";
            string parola = "nA123";

            string emailCheck, passwordCheck;
            do
            {
                Console.Write("Email bilgisini giriniz : ");
                emailCheck = Console.ReadLine();
                Console.Write("Password bilgisini giriniz : ");
                passwordCheck = Console.ReadLine();
            } while (emailCheck != email || passwordCheck != parola);

            //for Döngüsü 
            int sum = 0;
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ürün fiyatını giriniz : ");
                int fiyat = Convert.ToInt32(Console.ReadLine());
                sum += fiyat;
                result = fiyat;
                //Console.WriteLine("{0} kdvli fiyat {1}", fiyat, fiyat * 1.18);
            }

            //for-each Döngüsü 
            //for-each döngüsü listeler de ve array lerde ki değerleri dönebilmemize yarıyor.

            //***************************************//
            //            6.Gün Tekrar              //
            //*************************************//
            //ARRAYS-LİST
            //Array
            //tip[] diziIsmi = new tip[boyut] // Array tanımı//Ex : int[] rakamlar = 
            //indis numaraları 0 dan başlar 1 er 1 er artarak devam eder 
            int[] rakamlar = { 0, 1,2, 3, 4, 5, 6, 7, 8, 9 };
            //rakamlar[0] = 100; // 0.indis deki elemana 100 değeri atandı // alternatif : rakamlar.SetValue(100,0)
            string[] cities = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            // arraylerde boyut belirtmek zorundayız...
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Sayı giriniz : ");
                int s = Convert.ToInt32(Console.ReadLine());
                numbers[i] = s;
            }
            //int[,] matris = new int[5, 5]; // 5x5 boyutlarında matris
            //List
            List<int> myList = new List<int>(); //list tanımlanması 
            myList.Add(1992); //Listeye eleman ekleme
            myList.Add(1993);
            myList.Add(1994);
            myList.Add(1995);
            myList.Add(1996);
            myList.Insert(0,1988);

            //Listeyi elemanları tanımlayarak oluşturmak daha sonra genişletilebilir.
            List<string> sehirler = new List<string> 
            {
                "İstanbul",
                "İzmir",
                "Manisa",
                "Van",
            };
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

        }
        //***************************************//
        //            7.Gün Tekrar              //
        //*************************************//
        //METHODS
        //Parametreli ve parametresi methodlar vardır.
        //Geriye değer döndüren ve de döndürmeyen methodlar vardır.
        //Methodlara parametre olarak List,Array verebiliriz. Bunları bize yine list
        // array olarak döndürebilir.
        static void MerhabaDunya() //parametresiz method ve de geriye değer döndürmüyor.
        {
            Console.WriteLine("Merhaba Dünya");
        }
        static int TakeSquare(int sayi) // parametreli method ve de geriye int tipinde değer döndürüyor.
        {
            return sayi * sayi;
        }
    }
    //***************************************//
    //            8.Gün Tekrar              //
    //*************************************//
    //CLASSES
    //Sınıf (class), veriler içeren (değişken) ve bu verileri işleyen yapılardır. Ayrıca metotlar ile iş mantığı fonksiyonelliğini sağlarlar.
    //Araba nesnesi oluşturduk. Araba nesnemizde olması gereken özellikleri property olarak tanımladık.
    // Araba nesnesini kullanabilmemiz için bir instance'nı oluşturmamız gerekiyor. Kullanmak istediğimiz yerde.
    public class Araba //class tanımı 
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public void BilgiYaz() //Arabanın marka ve model bilgilerini ekrana yazdıran method tanımladık.
        {
            Console.WriteLine($"{Marka} {Model}");
        }
    }


}
