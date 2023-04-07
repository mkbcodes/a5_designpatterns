using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that represents a graphics card.
    /// </summary>
    public class GraphicsCard
    {
        /// <summary>
        /// The number of fans on the graphics card.
        /// </summary>
        public int FanCount { get; set; }

        private double _speed;

        /// <summary>
        /// The speed of the graphics card.
        /// </summary>
        public double Speed
        {
            get => _speed;
            set => _speed = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Graphics card speed cannot be less than 0.");
        }

        /// <summary>
        /// The amount of video memory on the graphics card.
        /// </summary>
        public int VideoMemory { get; set; }

        /// <summary>
        /// The number of CUDA cores on the graphics card.
        /// </summary>
        public int NumberOfCudaCores { get; set; }
    }
}
