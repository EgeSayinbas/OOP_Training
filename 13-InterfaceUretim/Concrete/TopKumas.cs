using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    public enum KalipTipi
    {
        GomlekArka=1
            , GomlekOn=2
            , GomlekKol=3
    }

    internal class TopKumas : IKalip, IKesilebilir
    {
        public IMakina SonrakiStep { get; set; }
        private bool _flag;
        private KalipTipi _KalipTipi;
        public void KalipCikar(KalipTipi kalipTipi)
        {
            _KalipTipi = kalipTipi;
            Console.WriteLine("Top kumastan kalip Cikartildi");
            _flag = true;
        }

        public void Kes()
        {
            //if (_flag)
            //    Console.WriteLine("Top kumas Kesimden cikti");
            //else 
            //    Console.WriteLine("Once Kalip Cikartilmasi gerekir");

            Console.WriteLine(_flag ==true? "Top kumas Kesimden cikti" : "Once Kalip Cikartilmasi gerekir");
            switch (_KalipTipi)
            {
                case KalipTipi.GomlekArka:
                    SonrakiStep.Calis();
                    break;
                case KalipTipi.GomlekOn:
                    SonrakiStep.Calis();
                    break;
                case KalipTipi.GomlekKol:
                    SonrakiStep.Calis();
                    break;
                default:
                    break;
            }

        }
    }
}
