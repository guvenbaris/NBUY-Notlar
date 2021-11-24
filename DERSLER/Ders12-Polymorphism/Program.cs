using System;
using Ders12_Polymorphism.AlanCevreHesapla;
using Ders12_Polymorphism.LokantaYazilimi;

namespace Ders12_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //LokantaManager lokantaManager = new LokantaManager(new MersinLokanta());
            //lokantaManager.LokantaMesajı();
            
            Daire daire = new Daire(5);
            daire.AlanHesapla();
            daire.CevreHesapla();

        }
    }
}
