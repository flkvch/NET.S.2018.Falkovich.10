using Clock;
using System;
using System.Threading;

namespace ConsoleClock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockWithCountdown clock = new ClockWithCountdown();
            Subscriber s1 = new MillisecondsCounter();
            Subscriber s2 = new SecondsCounter();
            Subscriber s3 = new MinutesCounter();
            s1.Register(clock);
            s2.Register(clock);
            clock.Countdown(1000);
            s3.Register(clock);
            clock.Countdown(5000);
            s2.Unregister(clock);
            s1.Unregister(clock);
            clock.Countdown(3000);
            s3.Unregister(clock);
            Console.ReadLine();
        }
    }
}
