using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{

    /// <summary>
    /// A class that represents a hard drive.
    /// </summary>
    public class HardDrive
    {
        private int _capacity;

        /// <summary>
        /// The capacity of the hard drive.
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            set => _capacity = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive capacity must be greater than 0.");
        }

        /// <summary>
        /// The type of hard drive.
        /// </summary>
        public HardDriveType Type { get; set; }

        /// <summary>
        /// The read speed of the hard drive.
        /// </summary>
        public int ReadSpeed { get; set; }

        /// <summary>
        /// The write speed of the hard drive.
        /// </summary>
        public int WriteSpeed { get; set; }
    }
}
