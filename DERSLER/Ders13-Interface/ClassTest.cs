using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface
{
    class ClassTest : ITest
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public void BilgiYaz()
        {
            Console.WriteLine($"Modeli {this.Model}, Markası : {this.Marka}");
        }
    }
}
