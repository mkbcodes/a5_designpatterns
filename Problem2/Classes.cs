using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Classes
    {
        public enum HardDriveType
        {
            HDD,
            SSD
        }
        public enum MemoryType
        {
            DDR1,
            DDR2,
            DDR3,
            DDR4
        }

        public class Case
        {
            public int Length { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int NumberOfFans { get; set; }
            public int NumberOfVents { get; set; }
        }

        public class Computer
        {
            public HardDrive HardDrive { get; set; }
            public Motherboard Motherboard { get; set; }
            public CPU Cpu { get; set; }
            public Memory Memory { get; set; }
            public GraphicsCard GraphicsCard { get; set; }
            public Case Case { get; set; }
        }

        public class ComputerBuilder
        {
            private Computer _computer;

            public ComputerBuilder()
            {
                _computer = new Computer();
            }

            public ComputerBuilder SetHardDrive(HardDrive hardDrive)
            {
                _computer.HardDrive = hardDrive ?? throw new ArgumentNullException(nameof(hardDrive));
                return this;
            }

            public ComputerBuilder SetMotherboard(Motherboard motherboard)
            {
                _computer.Motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
                return this;
            }

            public ComputerBuilder SetCPU(CPU cpu)
            {
                _computer.Cpu = cpu ?? throw new ArgumentNullException(nameof(cpu));
                return this;
            }

            public ComputerBuilder SetMemory(Memory memory)
            {
                _computer.Memory = memory ?? throw new ArgumentNullException(nameof(memory));
                return this;
            }

            public ComputerBuilder SetGraphicsCard(GraphicsCard graphicsCard)
            {
                _computer.GraphicsCard = graphicsCard ?? throw new ArgumentNullException(nameof(graphicsCard));
                return this;
            }
            public ComputerBuilder SetCase(Case computerCase)
            {
                _computer.Case = computerCase ?? throw new ArgumentNullException(nameof(computerCase));
                return this;
            }

            public Computer Build()
            {
                return _computer;
            }
        }

        public class CPU
        {
            private double _speed;

            public double Speed
            {
                get => _speed;
                set => _speed = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "CPU speed cannot be less than 0.");
            }

            public string Manufacturer { get; set; }
            public string SocketType { get; set; }
            public int CacheSize { get; set; }
            public int NumberOfCores { get; set; }
        }

        public class GraphicsCard
        {
            public int FanCount { get; set; }
            private double _speed;

            public double Speed
            {
                get => _speed;
                set => _speed = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Graphics card speed cannot be less than 0.");
            }

            public int VideoMemory { get; set; }
            public int NumberOfCudaCores { get; set; }
        }

        public class HardDrive
        {
            private int _capacity;

            public int Capacity
            {
                get => _capacity;
                set => _capacity = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive capacity must be greater than 0.");
            }

            public HardDriveType Type { get; set; }
            public int ReadSpeed { get; set; }
            public int WriteSpeed { get; set; }
        }

        public class Memory
        {
            public int ReadSpeed { get; set; }
            public int WriteSpeed { get; set; }
            public MemoryType Type { get; set; }
            private int _amountInGB;

            public int AmountInGB
            {
                get => _amountInGB;
                set => _amountInGB = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Memory amount must be greater than 0.");
            }
        }

        public class Motherboard
        {
            public int MemorySlots { get; set; }
            public int PowerConsumption { get; set; }
            public int PciSlots { get; set; }
            public string FormFactor { get; set; }
            private int _hardDriveLimit;

            public int HardDriveLimit
            {
                get => _hardDriveLimit;
                set => _hardDriveLimit = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Hard drive limit must be greater than 0.");
            }

            public CPU Cpu { get; set; }
            public Memory Memory { get; set; }
            public GraphicsCard GraphicsCard { get; set; }
        }
    }
}
