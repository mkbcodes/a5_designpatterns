using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// IObserver interface representing an observer of the auction item.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the observer with the current bid price of the auction item.
        /// </summary>
        /// <param name="currentBidPrice">The current bid price of the auction item.</param>
        void Update(decimal currentBidPrice);
    }

}
