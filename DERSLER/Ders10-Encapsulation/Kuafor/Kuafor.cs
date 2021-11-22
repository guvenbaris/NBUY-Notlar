using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Encapsulation.Kuafor
{
   public enum Hizmetler
    {
        Sac_Tirasi,
        Sakal_Tirasi,
        Sac_yikama,
        Cilt_Bakim
    }

   public class Kuafor
   {
       private float _toplamUcret;
       public List<Hizmetler> alinanHizmetlers = new List<Hizmetler>();

        public float _sacTrasiUcreti  { get; set; } 
       public float _ciltBakimi { get; set; }
       public float _sacYikama { get; set; }
       public float _sakalTrasi { get; set; }

       public Kuafor()
       {
           _toplamUcret = 0;
           _sacTrasiUcreti = 20f;
           _sacYikama = 10f;
           _ciltBakimi = 30f;
           _sakalTrasi = 15;
       }

       public void SacTrasiYap()
       {
           alinanHizmetlers.Add(Hizmetler.Sac_Tirasi);
           _toplamUcret += _sacTrasiUcreti;
       }
       public void SakarTrasiYap()
       {
           alinanHizmetlers.Add(Hizmetler.Sakal_Tirasi);
           _toplamUcret += _sakalTrasi;
       }
       public void SacYika()
       {
           alinanHizmetlers.Add(Hizmetler.Sac_yikama);
           _toplamUcret += _sacYikama;
       }
       public void CiltBakimiYap()
       {
           alinanHizmetlers.Add(Hizmetler.Cilt_Bakim);
           _toplamUcret += _ciltBakim;
       }
    }
}
