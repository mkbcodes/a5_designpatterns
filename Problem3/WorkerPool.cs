using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    // Represents a pool of worker objects that can be reused to process mail efficiently
    public class WorkerPool : IWorkerPool
    {
        private readonly Queue<Worker> _availableWorkers;

        public WorkerPool(int initialWorkerCount)
        {
            _availableWorkers = new Queue<Worker>();

            for (int i = 0; i < initialWorkerCount; i++)
            {
                _availableWorkers.Enqueue(new Worker { WorkerId = i });
            }
        }

        // Acquires a worker from the pool of available workers
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

        // Releases a worker back to the pool of available workers
        public void ReleaseWorker(Worker worker)
        {
            lock (_availableWorkers)
            {
                _availableWorkers.Enqueue(worker);
            }
        }
    }

}
