using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a stuffed animal toy.
    /// </summary>
    public class StuffedAnimal : Toy
    {
        /// <summary>
        /// The type of animal represented by the stuffed animal.
        /// </summary>
        public string? AnimalType { get; set; }
        /// <summary>
        /// The material the fur of the stuffed animal is made of.
        /// </summary>
        public string? FurMaterial { get; set; }

        /// <summary>
        /// Indicates whether the stuffed animal makes a sound.
        /// </summary>
        public bool HasSound { get; set; }

        /// <summary>
        /// Hugs the stuffed animal.
        /// </summary>
        public void Hug() { }

        /// <summary>
        /// Plays a sound made by the stuffed animal.
        /// </summary>
        public void PlaySound() { }
    }
}
