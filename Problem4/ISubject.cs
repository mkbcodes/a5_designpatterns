using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    /// <summary>
    /// ISubject interface representing the subject of the auction item.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers an observer to the subject.
        /// </summary>
        /// <param name="observer">The observer to be registered.</param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// Unregisters an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer to be unregistered.</param>
        void UnregisterObserver(IObserver observer);

        /// <summary>
        /// Notifies all observers of the subject.
        /// </summary>
        void NotifyObservers();
    }
}
