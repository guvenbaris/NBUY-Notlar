using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface
{
    interface ITest
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        void BilgiYaz();
    }
}
