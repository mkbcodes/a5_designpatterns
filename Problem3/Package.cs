using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Represents a package mail object that inherits from the Mail class and has additional properties for dimensions.
    /// </summary>
    public class Package : Mail
    {
        /// <summary>
        /// Gets or sets the length of the package.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets the width of the package.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the package.
        /// </summary>
        public double Height { get; set; }
    }
}
