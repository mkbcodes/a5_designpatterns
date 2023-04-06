

namespace Problem2
{
    /// <summary>
    /// A class that defines enums and classes used in building a computer.
    /// </summary>
    public class Classes
    {
        /// <summary>
        /// An enum that represents the type of hard drive.
        /// </summary>
        public enum HardDriveType
        {
            HDD,
            SSD
        }

        /// <summary>
        /// An enum that represents the type of memory.
        /// </summary>
        public enum MemoryType
        {
            DDR1,
            DDR2,
            DDR3,
            DDR4
        }

        /// <summary>
        /// A class that represents the case of the computer.
        /// </summary>
        public class Case
        {
            /// <summary>
            /// The length of the case.
            /// </summary>
            public int Length { get; set; }

            /// <summary>
            /// The width of the case.
            /// </summary>
            public int Width { get; set; }

            /// <summary>
            /// The height of the case.
            /// </summary>
            public int Height { get; set; }

            /// <summary>
            /// The number of fans in the case.
            /// </summary>
            public int NumberOfFans { get; set; }

            /// <summary>
            /// The number of vents in the case.
            /// </summary>
            public int NumberOfVents { get; set; }
        }

        /// <summary>
        /// A class that represents a computer.
        /// </summary>
        public class Computer
        {
            /// <summary>
            /// The hard drive of the computer.
            /// </summary>
            public HardDrive? HardDrive { get; set; }

            /// <summary>
            /// The motherboard of the computer.
            /// </summary>
            public Motherboard? Motherboard { get; set; }

            /// <summary>
            /// The CPU of the computer.
            /// </summary>
            public CPU? Cpu { get; set; }

            /// <summary>
            /// The memory of the computer.
            /// </summary>
            public Memory? Memory { get; set; }

            /// <summary>
            /// The graphics card of the computer.
            /// </summary>
            public GraphicsCard? GraphicsCard { get; set; }

            /// <summary>
            /// The case of the computer.
            /// </summary>
            public Case? Case { get; set; }
        }


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


        /// <summary>
        /// A class that represents a CPU.
        /// </summary>
        public class CPU
        {
            private double _speed;

            /// <summary>
            /// The speed of the CPU.
            /// </summary>
            public double Speed
            {
                get => _speed;
                set => _speed = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "CPU speed cannot be less than 0.");
            }

            /// <summary>
            /// The manufacturer of the CPU.
            /// </summary>
            public string? Manufacturer { get; set; }

            /// <summary>
            /// The socket type of the CPU.
            /// </summary>
            public string? SocketType { get; set; }

            /// <summary>
            /// The cache size of the CPU.
            /// </summary>
            public int CacheSize { get; set; }

            /// <summary>
            /// The number of cores of the CPU.
            /// </summary>
            public int NumberOfCores { get; set; }
        }

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

        /// <summary>
        /// A class that represents a hard drive.
        /// </summary>
        public class HardDrive
        {
            private int _capacity;

            /// <summary>
            /// The capacity of the hard drive.
            /// </summary>
            public int Capacity
            {
                get => _capacity;
                set => _capacity = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive capacity must be greater than 0.");
            }

            /// <summary>
            /// The type of hard drive.
            /// </summary>
            public HardDriveType Type { get; set; }

            /// <summary>
            /// The read speed of the hard drive.
            /// </summary>
            public int ReadSpeed { get; set; }

            /// <summary>
            /// The write speed of the hard drive.
            /// </summary>
            public int WriteSpeed { get; set; }
        }

        /// <summary>
        /// A class that represents memory.
        /// </summary>
        public class Memory
        {
            /// <summary>
            /// The read speed of the memory.
            /// </summary>
            public int ReadSpeed { get; set; }

            /// <summary>
            /// The write speed of the memory.
            /// </summary>
            public int WriteSpeed { get; set; }

            /// <summary>
            /// The type of memory.
            /// </summary>
            public MemoryType Type { get; set; }

            private int _amountInGB;

            /// <summary>
            /// The amount of memory in GB.
            /// </summary>
            public int AmountInGB
            {
                get => _amountInGB;
                set => _amountInGB = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Memory amount must be greater than 0.");
            }
        }

        /// <summary>
        /// A class that represents a motherboard.
        /// </summary>
        public class Motherboard
        {
            /// <summary>
            /// The number of memory slots on the motherboard.
            /// </summary>
            public int MemorySlots { get; set; }

            /// <summary>
            /// The power consumption of the motherboard.
            /// </summary>
            public int PowerConsumption { get; set; }

            /// <summary>
            /// The number of PCI slots on the motherboard.
            /// </summary>
            public int PciSlots { get; set; }

            /// <summary>
            /// The form factor of the motherboard.
            /// </summary>
            public string? FormFactor { get; set; }

            private int _hardDriveLimit;

            /// <summary>
            /// The hard drive limit of the motherboard.
            /// </summary>
            public int HardDriveLimit
            {
                get => _hardDriveLimit;
                set => _hardDriveLimit = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive limit must be greater than 0.");
            }

            /// <summary>
            /// The CPU of the motherboard.
            /// </summary>
            public CPU? Cpu { get; set; }

            /// <summary>
            /// The memory of the motherboard.
            /// </summary>
            public Memory? Memory { get; set; }

            /// <summary>
            /// The graphics card of the motherboard.
            /// </summary>
            public GraphicsCard? GraphicsCard { get; set; }
        }
    }
}
