using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{

    #region Konu Anlatimi
    // Abstract class'lar sadece kalitim verir.
    // Instance alinmaz
    #endregion
    public abstract class MuzikAleti
    {

        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }

        //public string Cal()
        //{
        //    return "Muzik Aleti caldi";
        //}
        //public string AkortYap()
        //{
        //    return "Muzik Aleti Akort Yapti";
        //}

        //1- Abstract metodlarin govdesi olmaz. Sadece metod imzalari vardir.
        //2- kalitim verdikleri yerde govdesinin yazilmasi şarttir.
        //3- Abstract metodlar ancak abstract siniflar iceisinde tanimlanabilir. 
        //4 Abstract olarak isaretlenmis tum metodlar mutlaka kalitim verildigi yerde override edilmek zorundadir.

        public abstract string Cal();


        //virtual olarakisaretlenen metodlarin govdesi yazilabilir
        // virtual metodlar abstract olsun yada olmasin butun claslarda tanimlanabilir.
        public virtual void AkordYap()
        {
            Console.WriteLine("Muzik Alieti Akord Edildi.");
        }
    }
}
