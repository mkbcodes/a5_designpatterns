using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    // Interface to define methods for managing worker objects in the pool
    public interface IWorkerPool
    {
        // Method to acquire a worker from the pool
        Worker AcquireWorker();

        // Method to release a worker back to the pool
        void ReleaseWorker(Worker worker);
    }

}
