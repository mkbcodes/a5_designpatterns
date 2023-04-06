
using Problem4;

namespace UnitTesting
{
    [TestClass]
    public class ProblemFourTests
    {
        /// <summary>
        /// Tests if placing a bid updates the current bid price for a bidder.
        /// </summary>
        [TestMethod]
        public void TestBidUpdatesCurrentBidPrice()
        {
            // Arrange
            var auctioneer = new Auctioneer();
            var auctionItem = new AuctionItem(100m, 2000);
            auctioneer.Item = auctionItem;
            var bidder = new Bidder("John Doe", 150m);
            auctioneer.RegisterObserver(bidder);

            // Act
            auctioneer.Bid(bidder, 110m);

            // Assert
            Assert.AreEqual(110m, bidder.CurrentBidPrice);
        }

    }


}
