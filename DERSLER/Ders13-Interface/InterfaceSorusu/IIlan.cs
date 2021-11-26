using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.InterfaceSorusu
{
    interface IIlan
    {
        public string IlanNo { get; set; }
        public DateTime IlanTarihi { get; set; }
        public Kullanici _Kullanici { get; set; }
    }
}
