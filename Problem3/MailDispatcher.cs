using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    // Represents a mail dispatcher that handles incoming mail requests and dispatches them to available workers for processing
    public class MailDispatcher
    {
        private readonly IWorkerPool _workerPool;

        public MailDispatcher(IWorkerPool workerPool)
        {
            _workerPool = workerPool;
        }

        // Receives a mail object, acquires a worker from the worker pool, and dispatches the mail to the worker for processing
        public void ProcessMail(Mail mail)
        {
            Worker worker = _workerPool.AcquireWorker();

            // Dispatch the mail to the worker
            worker.DetermineMailbox(mail);

            // Check if the mail is flagged
            if (mail.IsFlagged)
            {
                worker.HandleFlaggedMail(mail);
            }

            worker.ReturnToDispatcher();
            _workerPool.ReleaseWorker(worker);
        }
    }

}
