using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Auctioneer : ISubject
    {
        private List<IObserver> _observers;
        public AuctionItem Item { get; set; }

        public Auctioneer()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(Item.StartingPrice);
            }
        }

        public void Bid(Bidder bidder, decimal bidAmount)
        {
            if (bidAmount > Item.StartingPrice && bidAmount <= bidder.MaxBidLimit && Item.NumberOfBids < 5)
            {
                Item.StartingPrice = bidAmount;
                Item.NumberOfBids++;
                NotifyObservers();
            }
        }

        public Bidder CloseAuction()
        {
            Bidder highestBidder = null;
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
