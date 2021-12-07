using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> arr = new List<int> {1, 1, 0, -1, -1};

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
}
