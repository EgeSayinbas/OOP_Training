using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.FirinOrnegi
{
    internal class KaraFirin
    {
        //public void EkmekPisir(Usta usta)
        //{
        //    usta.HamurYogur();
        //}
        //public void EkmekPisir(Makina makina)
        //{
        //    makina.HamurYogur();
        //}

        public void EkmekPisir(IYogurma yogurucu)
        {
            yogurucu.HamurYogur();
        }
    }
}
