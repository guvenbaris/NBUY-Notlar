using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.InterfaceSorusu
{
    enum YakitTipi
    {
        Benzin,Dizel,Lpg
    }

    enum VitesTipi
    {
        Manuel,Otomatik,YarıOtomatik
    }

    enum KasaTipi
    {
        Sedan,Station
    }
    class Araba :  IVasita,IIlan
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public float MotorHacmi { get; set; }
        public Sigorta _sigorta { get; set; }
        public string IlanNo { get; set; }
        public DateTime IlanTarihi { get; set; }
        public Kullanici _Kullanici { get; set; }

        public void SigortaYap(DateTime myDateTime)
        {
            _sigorta.SigortaGuncelle();
        }

    }
}
