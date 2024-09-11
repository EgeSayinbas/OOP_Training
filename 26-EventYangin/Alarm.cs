using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public class Alarm
    {
        public event EventHandler AlarmCaldi;

        public void AlarmCal(object alarmiTetikleyen)
        {
            if(alarmiTetikleyen is Kablo)
            {
                Console.WriteLine("Alarm kablo yuzunden caldi");
                AlarmCaldi(this);
            }
            else if(alarmiTetikleyen is Sigara)
            {
                Console.WriteLine("Alarm sigara yuzunden caldi");
                AlarmCaldi(this);
            }
            else
            {
                Console.WriteLine("Alarm caldi");
            }
        }

    }
}
