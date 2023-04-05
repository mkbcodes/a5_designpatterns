using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Classes
    {
        /// <summary>
        /// Represents a toy with basic properties.
        /// </summary>
        public abstract class Toy
        {
            /// <summary>
            /// The name of the toy.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// A brief description of the toy.
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// The cost of the toy.
            /// </summary>
            public decimal Cost { get; set; }

            /// <summary>
            /// The company that manufactured the toy.
            /// </summary>
            public string ManufacturingCompany { get; set; }

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

        /// <summary>
        /// Represents a factory for creating toys of a specific type.
        /// </summary>
        public interface IToyFactory
        {
            /// <summary>
            /// Creates a new toy of the specific type.
            /// </summary>
            /// <returns>The new toy.</returns>
            Toy CreateToy();
        }

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
            public string Model { get; set; }

            /// <summary>
            /// The type of engine in the car.
            /// </summary>
            public string EngineType { get; set; }

            /// <summary>
            /// Drives the car.
            /// </summary>
            public void Drive() { }

            /// <summary>
            /// Honks the car's horn.
            /// </summary>
            public void Honk() { }
        }

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
            public string Material { get; set; }

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

            /// <summary>
            /// A factory for creating dollhouse toys.
            /// </summary>
            public class DollhouseFactory : IToyFactory
            {
                /// <summary>
                /// Creates a new dollhouse toy.
                /// </summary>
                /// <returns>The new dollhouse toy.</returns>
                public Toy CreateToy()
                {
                    return new Dollhouse();
                }
            }

            /// <summary>
            /// Represents a rainbow stacker toy.
            /// </summary>
            public class RainbowStacker : Toy
            {
                /// <summary>
                /// The number of rings in the stacker.
                /// </summary>
                public int RingCount { get; set; }

                /// <summary>
                /// The material the stacker is made of.
                /// </summary>
                public string Material { get; set; }

                /// <summary>
                /// Indicates whether the stacker is flexible.
                /// </summary>
                public bool IsFlexible { get; set; }

                /// <summary>
                /// Adds a ring to the stacker.
                /// </summary>
                public void StackRing() { }

                /// <summary>
                /// Removes a ring from the stacker.
                /// </summary>
                public void RemoveRing() { }
            }

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

            /// <summary>
            /// Represents a stuffed animal toy.
            /// </summary>
            public class StuffedAnimal : Toy
            {
                /// <summary>
                /// The type of animal represented by the stuffed animal.
                /// </summary>
                public string AnimalType { get; set; }
                /// <summary>
                /// The material the fur of the stuffed animal is made of.
                /// </summary>
                public string FurMaterial { get; set; }

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

            /// <summary>
            /// A factory for creating stuffed animal toys.
            /// </summary>
            public class StuffedAnimalFactory : IToyFactory
            {
                /// <summary>
                /// Creates a new stuffed animal toy.
                /// </summary>
                /// <returns>The new stuffed animal toy.</returns>
                public Toy CreateToy()
                {
                    return new StuffedAnimal();
                }
            }

        }
    }
}
