using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents a computer.
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// The hard drive of the computer.
        /// </summary>
        public HardDrive? HardDrive { get; set; }

        /// <summary>
        /// The motherboard of the computer.
        /// </summary>
        public Motherboard? Motherboard { get; set; }

        /// <summary>
        /// The CPU of the computer.
        /// </summary>
        public CPU? Cpu { get; set; }

        /// <summary>
        /// The memory of the computer.
        /// </summary>
        public Memory? Memory { get; set; }

        /// <summary>
        /// The graphics card of the computer.
        /// </summary>
        public GraphicsCard? GraphicsCard { get; set; }

        /// <summary>
        /// The case of the computer.
        /// </summary>
        public Case? Case { get; set; }
    }
}
