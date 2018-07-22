using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock;

namespace ConsoleClock
{
    class MillisecondsCounter : Subscriber
    {
        protected override void Message(object sender, TimeEventArgs e)
        {
            Console.WriteLine($"Initial time: {e.Initial}\nTime spend: {e.Milliseconds} millisecond.");       
        }
    }
}
