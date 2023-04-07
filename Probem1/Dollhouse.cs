using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    /// <summary>
    /// Represents a dollhouse toy.
    /// </summary>
    public class Dollhouse : Toy
    {
        /// <summary>
        /// The number of rooms in the dollhouse.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// The material the dollhouse is made of.
        /// </summary>
        public string? Material { get; set; }

        /// <summary>
        /// Indicates whether the dollhouse has lights.
        /// </summary>
        public bool HasLights { get; set; }

        /// <summary>
        /// Opens the door of the dollhouse.
        /// </summary>
        public void OpenDoor() { }

        /// <summary>
        /// Closes the door of the dollhouse.
        /// </summary>
        public void CloseDoor() { }
    }
}
