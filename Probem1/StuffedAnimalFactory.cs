using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// A factory for creating stuffed animal toys.
    /// </summary>
    public class StuffedAnimalFactory : IToyFactory
    {
        /// <summary>
        /// Creates a new stuffed animal toy.
        /// </summary>
        /// <returns>The new stuffed animal toy.</returns>
        public Toy CreateToy()
        {
            return new StuffedAnimal();
        }
    }
}
