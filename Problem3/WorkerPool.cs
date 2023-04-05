using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Represents a pool of worker objects that can be reused to process mail efficiently
    /// </summary>
    public class WorkerPool : IWorkerPool
    {
        private readonly Queue<Worker> _availableWorkers;

        /// <summary>
        /// Initializes a new instance of the WorkerPool class with an initial worker count.
        /// </summary>
        /// <param name="initialWorkerCount">The number of initial workers in the pool.</param>
        public WorkerPool(int initialWorkerCount)
        {
            _availableWorkers = new Queue<Worker>();

            for (int i = 0; i < initialWorkerCount; i++)
            {
                _availableWorkers.Enqueue(new Worker { WorkerId = i });
            }
        }

        /// <summary>
        /// Acquires a worker from the pool of available workers.
        /// </summary>
        /// <returns>A Worker object.</returns>
        public Worker AcquireWorker()
        {
            lock (_availableWorkers)
            {
                if (_availableWorkers.Count == 0)
                {
                    // Create a new worker if there are none available in the pool
                    int newWorkerId = _availableWorkers.Count;
                    return new Worker { WorkerId = newWorkerId };
                }

                return _availableWorkers.Dequeue();
            }
        }

        /// <summary>
        /// Releases a worker back to the pool of available workers.
        /// </summary>
        /// <param name="worker">A Worker object.</param>
        public void ReleaseWorker(Worker worker)
        {
            lock (_availableWorkers)
            {
                _availableWorkers.Enqueue(worker);
            }
        }
    }

}
