using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{

    /// <summary>
    /// A factory for creating dollhouse toys.
    /// </summary>
    public class DollhouseFactory : IToyFactory
    {
        /// <summary>
        /// Creates a new dollhouse toy.
        /// </summary>
        /// <returns>The new dollhouse toy.</returns>
        public Toy CreateToy()
        {
            return new Dollhouse();
        }
    }
}
