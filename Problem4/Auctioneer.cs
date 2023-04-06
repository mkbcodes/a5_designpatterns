using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{

        /// <summary>
        /// A class that represents an auctioneer.
        /// </summary>
        public class Auctioneer : ISubject
        {
            private List<IObserver> _observers;
            /// <summary>
            /// The item that is being auctioned.
            /// </summary>
            public AuctionItem? Item { get; set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="Auctioneer"/> class.
            /// </summary>
            public Auctioneer() => _observers = new List<IObserver>();

            /// <summary>
            /// Registers an observer to the auctioneer.
            /// </summary>
            /// <param name="observer">The observer to register.</param>
            public void RegisterObserver(IObserver observer)
            {
                _observers.Add(observer);
            }

            /// <summary>
            /// Unregisters an observer from the auctioneer.
            /// </summary>
            /// <param name="observer">The observer to unregister.</param>
            public void UnregisterObserver(IObserver observer)
            {
                _observers.Remove(observer);
            }

            /// <summary>
            /// Notifies all registered observers of a change.
            /// </summary>
            public void NotifyObservers()
            {
                foreach (IObserver observer in _observers)
                {
                    observer.Update(Item.StartingPrice);
                }
            }

            /// <summary>
            /// Places a bid on the auction item.
            /// </summary>
            /// <param name="bidder">The bidder placing the bid.</param>
            /// <param name="bidAmount">The amount of the bid.</param>
            public void Bid(Bidder bidder, decimal bidAmount)
            {
                if (bidAmount > Item.StartingPrice && bidAmount <= bidder.MaxBidLimit && Item.NumberOfBids < 5)
                {
                    Item.StartingPrice = bidAmount;
                    Item.NumberOfBids++;
                    NotifyObservers();
                }
            }

            /// <summary>
            /// Closes the auction and returns the highest bidder.
            /// </summary>
            /// <returns>The highest bidder.</returns>
            public Bidder CloseAuction()
            {
                Bidder? highestBidder = null;
                decimal highestBid = 0;

                foreach (IObserver observer in _observers)
                {
                    Bidder bidder = (Bidder)observer;
                    if (bidder.CurrentBidPrice > highestBid)
                    {
                        highestBid = bidder.CurrentBidPrice;
                        highestBidder = bidder;
                    }
                }

                if (highestBidder != null)
                {
                    UnregisterObserver(highestBidder);
                }

                return highestBidder;
            }
        }
    
}
