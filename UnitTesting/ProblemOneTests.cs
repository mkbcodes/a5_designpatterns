

using Problem1;
using Problem1;
using static Problem1.Classes.Dollhouse;
using static Problem1.Classes;

namespace UnitTesting
{
    [TestClass]
    public class ProblemOneTests
    {
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