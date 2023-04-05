
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem3;
using Problem4;

namespace AuctionTests
{
    [TestClass]
    public class AuctioneerTests
    {
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
