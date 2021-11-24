using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.AbstractOrnek
{
    class Ticari :Car
    {
        public byte TasimaKapasitesi { get; set; }
        private double _YeniFiyat = 0;
        public override double OtvHesapla()
        {

            if (this._MotorHacmi > 0 && this._MotorHacmi <= 999)
            {
                return _Fiyat;
            }
            else if (this._MotorHacmi > 999 && this._MotorHacmi <= 1599)
            {
                return _Fiyat * 1.05;
            }
            else if (this._MotorHacmi > 1599 && this._MotorHacmi <= 1999)
            {
                return _Fiyat * 1.10;
            }
            else
            {
                return _Fiyat * 1.15;
            }
        }

        public override double YillikVergiHesapla()
        {
            if (this._UretimYili.Year >= 0 && this._UretimYili.Year <= 4)
            {
                _YeniFiyat += this._Fiyat * 0.3 * 2;
            }
            else if (this._UretimYili.Year >= 5 && this._UretimYili.Year <= 9)
            {
                _YeniFiyat+= this._Fiyat * 0.2 *2;
            }
            else
            {
                _YeniFiyat +=  this._Fiyat * 0.1 *2;
            }

            if (this._MotorHacmi > 999 && this._MotorHacmi<= 1599)
            {
                _YeniFiyat += this._Fiyat * 0.02 * 2;
            }
            else if (this._MotorHacmi > 1599 && this._MotorHacmi <= 1999)
            {
                _YeniFiyat += this._Fiyat * 0.05 * 2;
            }
            else
            {
                _YeniFiyat += this._Fiyat * 0.01 * 2;
            }

            return _YeniFiyat;
        }
    }
} 
