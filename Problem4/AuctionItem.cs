using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class AuctionItem
    {
        public decimal StartingPrice { get; set; }
        public int YearOfCreation { get; set; }
        public int NumberOfBids { get; set; }

        public AuctionItem(decimal startingPrice, int yearOfCreation)
        {
            StartingPrice = startingPrice;
            YearOfCreation = yearOfCreation;
            NumberOfBids = 0;
        }
    }

}
