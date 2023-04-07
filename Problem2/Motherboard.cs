using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents a motherboard.
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// The number of memory slots on the motherboard.
        /// </summary>
        public int MemorySlots { get; set; }

        /// <summary>
        /// The power consumption of the motherboard.
        /// </summary>
        public int PowerConsumption { get; set; }

        /// <summary>
        /// The number of PCI slots on the motherboard.
        /// </summary>
        public int PciSlots { get; set; }

        /// <summary>
        /// The form factor of the motherboard.
        /// </summary>
        public string? FormFactor { get; set; }

        private int _hardDriveLimit;

        /// <summary>
        /// The hard drive limit of the motherboard.
        /// </summary>
        public int HardDriveLimit
        {
            get => _hardDriveLimit;
            set => _hardDriveLimit = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive limit must be greater than 0.");
        }

        /// <summary>
        /// The CPU of the motherboard.
        /// </summary>
        public CPU? Cpu { get; set; }

        /// <summary>
        /// The memory of the motherboard.
        /// </summary>
        public Memory? Memory { get; set; }

        /// <summary>
        /// The graphics card of the motherboard.
        /// </summary>
        public GraphicsCard? GraphicsCard { get; set; }
    }
}
