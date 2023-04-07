using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a toy car.
    /// </summary>
    public class Car : Toy
    {
        /// <summary>
        /// The number of wheels on the car.
        /// </summary>
        public int NumberOfWheels { get; set; }

        /// <summary>
        /// The model of the car.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// The type of engine in the car.
        /// </summary>
        public string? EngineType { get; set; }

        /// <summary>
        /// Drives the car.
        /// </summary>
        public void Drive() { }

        /// <summary>
        /// Honks the car's horn.
        /// </summary>
        public void Honk() { }
    }
}
