using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_EventBomba
{
    public delegate void BombaEvent();
    public class Telefon
    {
        
        public event BombaEvent KelimeKullanildiEvent;
        public void Gorusme()
        {
            Console.WriteLine("Alo anlamadim...");
            string input= Console.ReadLine();
            if(input.Contains("Kirmizi"))
            {
                KelimeKullanildiEvent();
                
            }
            if(input.Contains("Kapat"))
            {
                return;
            }
            Gorusme();
        }
    }
}
