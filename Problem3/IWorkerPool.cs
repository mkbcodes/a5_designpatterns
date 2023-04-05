using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Interface to define methods for managing worker objects in the pool.
    /// </summary>
    public interface IWorkerPool
    {
        /// <summary>
        /// Method to acquire a worker from the pool.
        /// </summary>
        /// <returns>A Worker object.</returns>
        Worker AcquireWorker();

        /// <summary>
        /// Method to release a worker back to the pool.
        /// </summary>
        /// <param name="worker">A Worker object.</param>
        void ReleaseWorker(Worker worker);
    }

}
