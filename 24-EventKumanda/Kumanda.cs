using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EventKumanda
{
    //delegate namespace seviyesinde yazilabilir ama event yazilamaz
    //namespace seviyesinde sadece Stuct , Enum , Class , Interface ve Delegate tanimlamasi yapilabilir 
    public delegate void EventKumandaEventHandler(string kod); //metod imzasi olan delegate
    
    public class Kumanda
    {
        public event EventKumandaEventHandler KumandayaBas;
        private readonly string _kod;

        public Kumanda(string kod)
        {
            this._kod = kod;
        }
        public void TusaBas()
        {
            Console.WriteLine("Kumandaya Basildi");
            KumandayaBas(_kod);
        }
    }
}
