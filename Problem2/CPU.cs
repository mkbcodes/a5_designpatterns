using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents a CPU.
    /// </summary>
    public class CPU
    {
        private double _speed;

        /// <summary>
        /// The speed of the CPU.
        /// </summary>
        public double Speed
        {
            get => _speed;
            set => _speed = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "CPU speed cannot be less than 0.");
        }

        /// <summary>
        /// The manufacturer of the CPU.
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// The socket type of the CPU.
        /// </summary>
        public string? SocketType { get; set; }

        /// <summary>
        /// The cache size of the CPU.
        /// </summary>
        public int CacheSize { get; set; }

        /// <summary>
        /// The number of cores of the CPU.
        /// </summary>
        public int NumberOfCores { get; set; }
    }
}
