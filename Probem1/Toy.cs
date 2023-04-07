using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a toy with basic properties.
    /// </summary>
    public abstract class Toy
    {
        /// <summary>
        /// The name of the toy.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// A brief description of the toy.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The cost of the toy.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// The company that manufactured the toy.
        /// </summary>
        public string? ManufacturingCompany { get; set; }

        /// <summary>
        /// The year the toy was manufactured.
        /// </summary>
        public int YearOfManufacture { get; set; }

        /// <summary>
        /// The minimum age recommended for using the toy.
        /// </summary>
        public int MinimumAgeLimit { get; set; }

        /// <summary>
        /// The maximum age recommended for using the toy.
        /// </summary>
        public int MaximumAgeLimit { get; set; }

        /// <summary>
        /// Indicates whether the toy contains parts that could be a choking hazard.
        /// </summary>
        public bool ChokingHazard { get; set; }

        /// <summary>
        /// The weight of the toy.
        /// </summary>
        public double Weight { get; set; }
    }
}
