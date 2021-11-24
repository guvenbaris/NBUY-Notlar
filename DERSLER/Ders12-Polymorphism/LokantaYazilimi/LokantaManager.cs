using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Polymorphism.LokantaYazilimi
{
    class LokantaManager
    {
        private Lokanta _lokanta;

        public LokantaManager(Lokanta lokanta)
        {
            this._lokanta = lokanta;
        }

        public void LokantaMesajı()
        {
            this._lokanta.BelediyeHarcOde();
        }
    }
}
