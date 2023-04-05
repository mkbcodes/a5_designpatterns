using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Bidder : IObserver
    {
        public string Name { get; set; }
        public decimal MaxBidLimit { get; set; }
        public decimal CurrentBidPrice { get; private set; }

        public Bidder(string name, decimal maxBidLimit)
        {
            Name = name;
            MaxBidLimit = maxBidLimit;
        }

        public void Update(decimal currentBidPrice)
        {
            CurrentBidPrice = currentBidPrice;
        }
    }


}
