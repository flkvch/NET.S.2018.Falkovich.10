using System;
using Clock;

namespace ConsoleClock
{
    public abstract class Subscriber
    {
        /// <summary>
        /// Message for the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="TimeEventArgs"/> instance containing the event data.</param>
        protected abstract void Message(object sender, TimeEventArgs e);

        /// <summary>
        /// Registers the specified Subscriber.
        /// </summary>
        /// <param name="clock">The clock.</param>
        public void Register(ClockWithCountdown clock)
        {
            clock.ClockCountdown += Message;
            Console.WriteLine($"The subscriber {GetType()} registered.");
        }

        /// <summary>
        /// Unregisters the specified Subscriber.
        /// </summary>
        /// <param name="clock">The clock.</param>
        public void Unregister(ClockWithCountdown clock)
        {
            clock.ClockCountdown -= Message;
            Console.WriteLine($"The subscriber {GetType()} unregistered.");
        }
    }
}
