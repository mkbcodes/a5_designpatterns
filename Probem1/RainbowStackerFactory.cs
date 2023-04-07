using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// A factory for creating rainbow stacker toys.
    /// </summary>
    public class RainbowStackerFactory : IToyFactory
    {
        /// <summary>
        /// Creates a new rainbow stacker toy.
        /// </summary>
        /// <returns>The new rainbow stacker toy.</returns>
        public Toy CreateToy()
        {
            return new RainbowStacker();
        }
    }
}
