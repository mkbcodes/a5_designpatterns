using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// Bidder class representing a person who is bidding on an auction item.
    /// </summary>
    public class Bidder : IObserver
    {
        /// <summary>
        /// The name of the bidder.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The maximum bid limit of the bidder.
        /// </summary>
        public decimal MaxBidLimit { get; set; }

        /// <summary>
        /// The current bid price of the bidder.
        /// </summary>
        public decimal CurrentBidPrice { get; private set; }

        /// <summary>
        /// Constructor for Bidder class that sets the name and maximum bid limit of the bidder.
        /// </summary>
        /// <param name="name">The name of the bidder.</param>
        /// <param name="maxBidLimit">The maximum bid limit of the bidder.</param>
        public Bidder(string name, decimal maxBidLimit)
        {
            Name = name;
            MaxBidLimit = maxBidLimit;
        }

        /// <summary>
        /// Updates the current bid price of the bidder.
        /// </summary>
        /// <param name="currentBidPrice">The current bid price of the auction item.</param>
        public void Update(decimal currentBidPrice)
        {
            CurrentBidPrice = currentBidPrice;
        }
    }

}
