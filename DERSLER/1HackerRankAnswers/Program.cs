using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1HackerRankAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlusMinus(); 1.Soru

            //MinMaxSum(); 2.Soru

            //TimeConversion(); 3.soru

            //SparceArrays(); 4. soru

            //LonelyInteger();  5.Soru

            //FlippingBits();  6.Soru

            //diagonalDifference(); 7.soru

            //CountingSort(); 8.Soru

            //Pangrams(); 9.Soru

            //Consonant();

            //PrimeNumber();


            bool isValid = true;
            bool isType = true;
            string choose = "";
            float hour = 0.0f;
            List<string> chooseList = new List<string>
            {
                "1", "2", "3", "4"

            };

            //while (isValid)
            //{
            //    Console.WriteLine("Araç tipini seçiniz...");
            //    Console.WriteLine("Otomobil için 1’e basın");
            //    Console.WriteLine("Motosiklet için 2’ye basın");
            //    Console.WriteLine(" Minibüs için 3’e basın");
            //    Console.WriteLine("Kamyon (ve diğer ticari araçlar) için 4’e basın");


            //    choose = Console.ReadLine();

            //    foreach (var ch in chooseList)
            //    {
            //        if (ch == choose)
            //        {
            //            isValid = false;
            //        }
            //    }
            //}


            while(isType)
            {
                Console.Write("Araç kaç saat boyunca park alanında kaldı ?  : ");
                var degisken =  Console.ReadLine();

                var conditionInt =  Int32.TryParse(degisken, out _);
                var conditionFLoat =  float.TryParse(degisken, out _);

                if (conditionInt == false && conditionFLoat == true)
                {
                    hour = Convert.ToSingle(degisken);
                    isType = false;
                    break;
                }

                Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
            }




            Console.ReadLine();

        }


        private static void PrimeNumber()
        {
            int prime = 2;

            bool success = true;
            //2 konrol edilecek sonra

            for (int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    success = false;
                }
            }

            if (prime == 2)
            {
                success = true;
            }

            if (success)
            {
                Console.WriteLine("Sayi asaldır.");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir.");
            }
        }

        private static void Consonant()
        {
            string input = "Hello World";

            string character = "a,e,i,o,u";

            input = input.ToLower().Replace(" ", string.Empty);
            int result = 0;

            foreach (var consonant in input)
            {
                foreach (var char1 in character)
                {
                    if (consonant == char1)
                    {
                        result += 1;
                    }
                }
            }

            Console.WriteLine(input.Length - result);
        }

        private static void Pangrams()
        {
            
            string s = "We promptly judged antique ivory buckles for the prize";

            string englishWords = "ABCDEFGHiJKLMNOPQRSTUVWXYZ";

            string lowerEnglish = englishWords.ToLower();
            string sentence = s.ToLower();
            Console.WriteLine(sentence);
            Console.WriteLine(lowerEnglish);
            string result = "";

            foreach (var enligsh in lowerEnglish)
            {
                foreach (var w in sentence)
                {
                    if (w == enligsh)
                    {
                        if (!result.Contains(w))
                        {
                            result += w;
                        }
                    }
                }
            }

            if (result.Length == englishWords.Length)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }

        private static void CountingSort()
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                arr.Add(i);
            }

            int[] res = new int[100];
            int val = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                val = arr[i];
                res[val] += 1;
            }

            List<int> fin = new List<int>(res);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            //Matrisin diagonal karşılıklarını bulma
            int sumRight = 0;
            int sumLeft = 0;

            for (int i = 0; i < (arr.Count); i++)
            {
                sumRight += arr[i][i];
                sumLeft += arr[i][arr.Count - 1 - i];
            }
            return Math.Abs(sumRight - sumLeft);
        }


        private static void FlippingBits()
        {
            // tilda işareti tersi anlamına geliyor 
            // uint olarak casting yapıyoruz 
            long sayi = 2147483647;
            Console.WriteLine((uint)~sayi);
        }
        private static void LonelyInteger()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 1, 2, 3 };
            int count = 0;
            int unique = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count += 1;
                    }
                }
                if (count != 2)
                {
                    unique = numbers[i];
                }
                count = 0;
            }

            Console.WriteLine(unique);
        }

        private static void SparceArrays()
        {
            List<string> strgins = new List<string>
            {
                "ab",
                "ab",
                "abc"
            };
            List<string> queries = new List<string>
            {
                "ab", "abc", "bc"
            };
            int expression = 0;
            List<int> result = new List<int>();

            foreach (var query in queries)
            {
                foreach (var strgin in strgins)
                {
                    if (query == strgin)
                    {
                        expression += 1;
                    }
                }

                result.Add(expression);
                expression = 0;
            }

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private static void TimeConversion()
        {
            string s = "12:01:00AM";
            string mySaat = "";
            string variable = "";
            int clock = 0;

            if (s.Contains("PM"))
            {
                if (s.StartsWith("12"))
                {
                    for (int i = 0; i < s.Length - 2; i++)
                    {
                        mySaat += s[i];
                    }
                }
                else
                {
                    variable = s.Substring(0, 2);
                    clock = Convert.ToInt32(variable) + 12;
                    mySaat = Convert.ToString(clock);

                    for (int i = 2; i < s.Length - 2; i++)
                    {
                        mySaat += s[i];
                    }
                }
            }
            else
            {
                if (s.StartsWith("12"))
                {
                    variable = s.Substring(0, 2);
                    mySaat = "00";
                    for (int i = 2; i < s.Length - 2; i++)
                    {
                        mySaat += s[i];
                    }
                }
                else
                {
                    for (int i = 0; i < s.Length - 2; i++)
                    {
                        mySaat += s[i];
                    }
                }
            }
            Console.WriteLine(mySaat);
        }

        private static void MinMaxSum()
        {
            List<int> arr = new List<int>
            {
                1, 2, 3, 45, 5, 67, 7, 78
            };

            long minSum = 0;
            long maxSum = 0;
            arr.Sort();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                minSum += arr[i];
            }

            for (int i = arr.Count - 1; i > 0; i--)
            {
                maxSum += arr[i];
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }

        private static void PlusMinus()
        {
            List<int> arr = new List<int> { 1, 1, 0, -1, -1 };

            double positive = 0;
            double negative = 0;
            double zeros = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positive += 1;
                }
                else if (item < 0)
                {
                    negative += 1;
                }
                else
                {
                    zeros += 1;
                }
            }
            Console.WriteLine(positive / arr.Count);
            Console.WriteLine(negative / arr.Count);
            Console.WriteLine(zeros / arr.Count);
        }
    }



    public static class MyExtensions
    {
        public static void IsValidPassword(this string str,params object[] logics)
        {
            ParameterInfo parameterInfo = typeof(MyExtensions).GetMethod("IsValidPassword").GetParameters()[1];

            PropertyInfo[] pi = logics.GetType().GetProperties();
            foreach (var property in pi)
            {
                Console.WriteLine(property.Name,property.GetValue(logics, null));
            }

            //str ve logics parametrelerini aldık bunun devamnına bakacağız...




        }
    }
}
