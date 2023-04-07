

using Problem1;

namespace UnitTesting
    {
        /// <summary>
        /// Contains unit tests for Problem 1.
        /// </summary>
        [TestClass]
        public class ProblemOneTests
        {
            /// <summary>
            /// Tests if CarFactory creates a Car object.
            /// </summary>
            [TestMethod]
            public void CarFactory_CreateToy_ReturnsCar()
            {
                // Arrange
                IToyFactory factory = new CarFactory();

                // Act
                Toy car = factory.CreateToy();

                // Assert
                Assert.IsInstanceOfType(car, typeof(Car));
            }

            /// <summary>
            /// Tests if DollhouseFactory creates a Dollhouse object.
            /// </summary>
            [TestMethod]
            public void DollhouseFactory_CreateToy_ReturnsDollhouse()
            {
                // Arrange
                IToyFactory factory = new DollhouseFactory();

                // Act
                Toy dollhouse = factory.CreateToy();

                // Assert
                Assert.IsInstanceOfType(dollhouse, typeof(Dollhouse));
            }

            /// <summary>
            /// Tests if RainbowStackerFactory creates a RainbowStacker object.
            /// </summary>
            [TestMethod]
            public void RainbowStackerFactory_CreateToy_ReturnsRainbowStacker()
            {
                // Arrange
                IToyFactory factory = new RainbowStackerFactory();

                // Act
                Toy rainbowStacker = factory.CreateToy();

                // Assert
                Assert.IsInstanceOfType(rainbowStacker, typeof(RainbowStacker));
            }

            /// <summary>
            /// Tests if StuffedAnimalFactory creates a StuffedAnimal object.
            /// </summary>
            [TestMethod]
            public void StuffedAnimalFactory_CreateToy_ReturnsStuffedAnimal()
            {
                // Arrange
                IToyFactory factory = new StuffedAnimalFactory();

                // Act
                Toy stuffedAnimal = factory.CreateToy();

                // Assert
                Assert.IsInstanceOfType(stuffedAnimal, typeof(StuffedAnimal));
            }
        }
    }

