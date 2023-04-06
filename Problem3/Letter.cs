using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Represents a letter mail object that inherits from the Mail class and has an additional property for the number of pages.
    /// </summary>
    public class Letter : Mail
    {
        /// <summary>
        /// Gets or sets the number of pages of the letter.
        /// </summary>
        public int NumberOfPages { get; set; }
    }
}
