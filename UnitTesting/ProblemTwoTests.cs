using static Problem2.Classes;

namespace UnitTesting
{
    /// <summary>
    /// When you are done, you should have 5 tests that pass.
    /// </summary>
    [TestClass]
    public class ProblemTwoTests
    {
                
            /// <summary>
            /// When called with a negative number, the method should throw an ArgumentOutOfRangeException.
            /// </summary>
            [TestMethod]
            public void CapacityCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new HardDrive { Capacity = -1 });
            }
            /// <summary>
            /// When called with a 0, the method should throw an ArgumentOutOfRangeException.
            /// </summary>

            [TestMethod]
            public void CapacityMustBeGreaterThanZero()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new HardDrive { Capacity = 0 });
            }
            /// <summary>
            /// When CPU is instantiated, if it is called with a negative speed number, the method should throw an ArgumentOutOfRangeException.
            /// </summary>

            [TestMethod]
            public void SpeedCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CPU { Speed = -1 });
            }
            /// <summary>
            /// When CPU is instantiated, if it is called with a 0 speed number, the method should throw an ArgumentOutOfRangeException.
            /// </summary>
            [TestMethod]
            public void AmountInGBCannotBeNegative()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Memory { AmountInGB = -1 });
            }

            /// <summary>
            /// When Memory is instantiated with an amountingb storage equal to 0, the method should throw an ArgumentOutOfRangeException.
            /// </summary>
            [TestMethod]
            public void AmountInGBMustBeGreaterThanZero()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Memory { AmountInGB = 0 });
            }
    
    }
}