using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Gitar :MuzikAleti
    {
        public override string Marka { get ; set ; }
        public override string Model { get; set ; }

        //public string Cal()
        //{
        //    return "Gitar Caldi";
        //}

        public override string Cal()
        {
            return "Gitar Caldi";
        }
        public override void AkordYap()
        {
            Console.WriteLine("Gitar Akord edildi");
        }
        public override string ToString()
        {
            return $"Marka {Marka} Model {Model}";
        }
    }
}
