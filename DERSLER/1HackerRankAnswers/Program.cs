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
            List<int> arr = new List<int>
            {
                1,3,5,7,9
            };

            int minSum = 0;
            int maxSum = 0;
            int total = 0;

            foreach (var item in arr)
            {
                
            }

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
