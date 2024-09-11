using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public class Itfaiye
    {
        public void MudahaleEt(object yardimCagiran)
        {
            if(yardimCagiran is Alarm)
            {
                Console.WriteLine("itfaiye yangina mudahale etti");
            }
        }
    }
}
