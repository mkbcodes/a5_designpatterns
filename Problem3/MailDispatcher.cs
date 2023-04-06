using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class MailDispatcher :IDispatcherObserver
    {
        private readonly IWorkerPool _workerPool;

        /// <summary>
        /// Initializes a new instance of the MailDispatcher class with a worker pool.
        /// </summary>
        /// <param name="workerPool">An instance of the IWorkerPool interface.</param>
        public MailDispatcher(IWorkerPool workerPool)
        {
            _workerPool = workerPool;
        }

        /// <summary>
        /// Releases a worker back to the worker pool.
        /// </summary>
        /// <param name="worker">The observer, or the mail room worker.</param>
        public void OnWorkerAvailable(Worker worker)
        {
            _workerPool.ReleaseWorker(worker);
        }

        /// <summary>
        /// Receives a mail object, acquires a worker from the worker pool, and dispatches the mail to the worker for processing.
        /// </summary>
        /// <param name="mail">A Mail object.</param>
        public void ProcessMail(Mail mail)
        {
            Worker worker = _workerPool.AcquireWorker();
            worker.DispatcherObserver = this;

            // Dispatch the mail to the worker
            worker.DetermineMailbox(mail);

            // Check if the mail is flagged
            if (mail.IsFlagged)
            {
                worker.HandleFlaggedMail(mail);
            }

            worker.ReturnToDispatcher();
        }

    }
}
