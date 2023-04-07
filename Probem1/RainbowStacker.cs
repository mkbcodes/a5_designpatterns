using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a rainbow stacker toy.
    /// </summary>
    public class RainbowStacker : Toy
    {
        /// <summary>
        /// The number of rings in the stacker.
        /// </summary>
        public int RingCount { get; set; }

        /// <summary>
        /// The material the stacker is made of.
        /// </summary>
        public string? Material { get; set; }

        /// <summary>
        /// Indicates whether the stacker is flexible.
        /// </summary>
        public bool IsFlexible { get; set; }

        /// <summary>
        /// Adds a ring to the stacker.
        /// </summary>
        public void StackRing() { }

        /// <summary>
        /// Removes a ring from the stacker.
        /// </summary>
        public void RemoveRing() { }
    }
}
