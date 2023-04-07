using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents memory.
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// The read speed of the memory.
        /// </summary>
        public int ReadSpeed { get; set; }

        /// <summary>
        /// The write speed of the memory.
        /// </summary>
        public int WriteSpeed { get; set; }

        /// <summary>
        /// The type of memory.
        /// </summary>
        public MemoryType Type { get; set; }

        private int _amountInGB;

        /// <summary>
        /// The amount of memory in GB.
        /// </summary>
        public int AmountInGB
        {
            get => _amountInGB;
            set => _amountInGB = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Memory amount must be greater than 0.");
        }
    }
}
