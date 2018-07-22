using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public sealed class TimeEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeEventArgs"/> class.
        /// </summary>
        /// <param name="initial">The initial.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        public TimeEventArgs(DateTime initial, int milliseconds)
        {
            Initial = initial;
            Milliseconds = milliseconds;
        }

        /// <summary>
        /// Gets the initial time.
        /// </summary>
        /// <value>
        /// The initial time.
        /// </value>
        public DateTime Initial { get; }

        /// <summary>
        /// Gets the milliseconds.
        /// </summary>
        /// <value>
        /// The milliseconds.
        /// </value>
        public int Milliseconds { get; }
    }
}
