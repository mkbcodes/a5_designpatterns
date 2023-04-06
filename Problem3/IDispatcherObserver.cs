using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Used to represent the Observer, or the Mail Worker, being available. Therefore it's assigned to every Mail Worker.
    /// </summary>
    public interface IDispatcherObserver
    {   
        // Method to be called when a worker is available
        void OnWorkerAvailable(Worker worker);
    }

}
