using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders14_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();

            var cities = new Dictionary<string, string>()
            { 
                {"Turkiye","Sakarya, Konya, İstanbul"},
                {"India","Mumbai,New Delphi,Pune"},
                {"UK","London,Manchester,Birmingham"},
                {"USA","Chicago,New Work,Washingtom"}
            };
            foreach (var item in cities)
            {
                Console.WriteLine(item.Key);   
            }

            Console.WriteLine(cities.Count());
            
        }
    }
}
