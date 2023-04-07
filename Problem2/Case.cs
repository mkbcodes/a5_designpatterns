using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents the case of the computer.
    /// </summary>
    public class Case
    {
        /// <summary>
        /// The length of the case.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// The width of the case.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// The height of the case.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// The number of fans in the case.
        /// </summary>
        public int NumberOfFans { get; set; }

        /// <summary>
        /// The number of vents in the case.
        /// </summary>
        public int NumberOfVents { get; set; }
    }
}
