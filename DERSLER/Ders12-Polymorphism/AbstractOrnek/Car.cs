using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AbstractOrnek
{
   abstract class Car
    {
        public int Id { get; set; }
        public int _MotorHacmi { get; set; }
        public byte _VitesSayisi { get; set; }
        public double _Fiyat { get; set; }
        public DateTime _UretimYili { get; set; }

        public Car()
        {
            
        }
        protected Car(int id, int motorHacmi, byte vitesSayisi, double fiyat, DateTime uretimYili)
        {
            Id = id;
            _MotorHacmi = motorHacmi;
            _VitesSayisi = vitesSayisi;
            _Fiyat = fiyat;
            _UretimYili = uretimYili;
        }

        public double IndirimYap(int rate)
        {
            return (this._Fiyat - (rate * this._Fiyat)  / 100);
        }

        public double GetFiyat()
        {
            return this._Fiyat;
        }

        public abstract double OtvHesapla();
        public abstract double YillikVergiHesapla();
    }
}
