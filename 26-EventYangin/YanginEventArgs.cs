using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public delegate void EventHandler(object sender);
    public class YanginEventArgs : EventArgs
    {
        public int State { get; set; } = 1;

    }
}
