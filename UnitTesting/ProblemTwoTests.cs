using Problem1;
using Problem1;
using static Problem2.Classes;

namespace UnitTesting
{
    [TestClass]
    public class ProblemTwoTests
    {
        
            [TestMethod]
            public void CapacityCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new HardDrive { Capacity = -1 });
            }

            [TestMethod]
            public void CapacityMustBeGreaterThanZero()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new HardDrive { Capacity = 0 });
            }

            [TestMethod]
            public void SpeedCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CPU { Speed = -1 });
            }
            [TestMethod]
            public void AmountInGBCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Memory { AmountInGB = -1 });
            }

            [TestMethod]
            public void AmountInGBMustBeGreaterThanZero()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Memory { AmountInGB = 0 });
            }
    
    }
}