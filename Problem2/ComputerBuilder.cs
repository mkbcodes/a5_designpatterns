using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    /// <summary>
    /// A class that helps build a computer.
    /// </summary>
    public class ComputerBuilder
    {
        /// <summary>
        /// This is the computer that is being built.
        /// </summary>
        private Computer _computer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerBuilder"/> class.
        /// </summary>
        public ComputerBuilder()
        {
            _computer = new Computer();
        }


        /// <summary>
        /// Sets the hard drive of the computer.
        /// </summary>
        /// <param name="hardDrive">The hard drive to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetHardDrive(HardDrive hardDrive)
        {
            _computer.HardDrive = hardDrive ?? throw new ArgumentNullException(nameof(hardDrive));
            return this;
        }

        /// <summary>
        /// Sets the motherboard of the computer.
        /// </summary>
        /// <param name="motherboard">The motherboard to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetMotherboard(Motherboard motherboard)
        {
            _computer.Motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
            return this;
        }

        /// <summary>
        /// Sets the CPU of the computer.
        /// </summary>
        /// <param name="cpu">The CPU to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetCPU(CPU cpu)
        {
            _computer.Cpu = cpu ?? throw new ArgumentNullException(nameof(cpu));
            return this;
        }

        /// <summary>
        /// Sets the memory of the computer.
        /// </summary>
        /// <param name="memory">The memory to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetMemory(Memory memory)
        {
            _computer.Memory = memory ?? throw new ArgumentNullException(nameof(memory));
            return this;
        }

        /// <summary>
        /// Sets the graphics card of the computer.
        /// </summary>
        /// <param name="graphicsCard">The graphics card to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetGraphicsCard(GraphicsCard graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard ?? throw new ArgumentNullException(nameof(graphicsCard));
            return this;
        }

        /// <summary>
        /// Sets the case of the computer.
        /// </summary>
        /// <param name="computerCase">The case to set.</param>
        /// <returns>The computer builder.</returns>
        public ComputerBuilder SetCase(Case computerCase)
        {
            _computer.Case = computerCase ?? throw new ArgumentNullException(nameof(computerCase));
            return this;
        }

        /// <summary>
        /// Builds the computer.
        /// </summary>
        /// <returns>The built computer.</returns>
        public Computer Build()
        {
            return _computer;
        }
    }
}
