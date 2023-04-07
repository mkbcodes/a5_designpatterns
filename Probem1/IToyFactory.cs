using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a factory for creating toys of a specific type.
    /// </summary>
    public interface IToyFactory
    {
        /// <summary>
        /// Creates a new toy of the specific type.
        /// </summary>
        /// <returns>The new toy.</returns>
        Toy CreateToy();
    }
}
