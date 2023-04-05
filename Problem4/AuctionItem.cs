using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// AuctionItem class representing an auction item that will be sold.
    /// </summary>
    public class AuctionItem
    {
        /// <summary>
        /// The starting price of the item.
        /// </summary>
        public decimal StartingPrice { get; set; }
        /// <summary>
        /// The year the item was created.
        /// </summary>
        public int YearOfCreation { get; set; }

    /// <summary>
    /// The number of bids placed on the item.
    /// </summary>
    public int NumberOfBids { get; set; }

    /// <summary>
    /// Constructor for AuctionItem class that sets the starting price, year of creation, and number of bids to 0.
    /// </summary>
    /// <param name="startingPrice">The starting price of the item.</param>
    /// <param name="yearOfCreation">The year the item was created.</param>
    public AuctionItem(decimal startingPrice, int yearOfCreation)
    {
        StartingPrice = startingPrice;
        YearOfCreation = yearOfCreation;
        NumberOfBids = 0;
    }
}
}
