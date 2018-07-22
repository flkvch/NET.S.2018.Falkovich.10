using System;
using System.Threading;

namespace Clock
{
    public class ClockWithCountdown
    {
        /// <summary>
        /// Occurs when [clock countdown].
        /// </summary>
        public event EventHandler<TimeEventArgs> ClockCountdown;

        /// <summary>
        /// Called when [clock countdown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="TimeEventArgs"/> instance containing the event data.</param>
        private void OnClockCountdown(object sender, TimeEventArgs e)
        {
            ClockCountdown?.Invoke(this, e);
        }

        /// <summary>
        /// Countdowns the specified milliseconds.
        /// </summary>
        /// <param name="milliseconds">The milliseconds.</param>
        public void Countdown(int milliseconds)
        {
            var initialTime = DateTime.Now;
            Thread.Sleep(milliseconds);
            OnClockCountdown(this, new TimeEventArgs(initialTime, milliseconds));
        }
    }
}
