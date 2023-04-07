using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// A factory for creating toy cars.
    /// </summary>
    public class CarFactory : IToyFactory
    {
        /// <summary>
        /// Creates a new car toy.
        /// </summary>
        /// <returns>The new car toy.</returns>
        public Toy CreateToy()
        {
            return new Car();
        }
    }
}
