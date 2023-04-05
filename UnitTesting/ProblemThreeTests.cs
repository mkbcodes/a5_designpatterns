using Problem3;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{

     
    [TestClass]
    public class Problem3
    {
        /// <summary>
        /// A test method that verifies the DetermineMailbox method assigns the correct mailbox.
        /// </summary>
        [TestMethod]
        public void DetermineMailbox_AssignsCorrectMailbox()
        {
            // Arrange
            Person sender = new Person { Name = "John Doe", Address = "123 Sender St" };
            Person receiver = new Person { Name = "Jane Doe", Address = "456 Receiver St" };

            Mail mail = new Mail
            {
                Sender = sender,
                Receiver = receiver
            };

            WorkerPool workerPool = new WorkerPool(1);
            Worker worker = workerPool.AcquireWorker();
            string expectedMailboxNumber = mail.Receiver.Address.GetHashCode().ToString();

            // Act
            string actualMailboxNumber = worker.DetermineMailbox(mail);

            // Assert
            Assert.AreEqual(expectedMailboxNumber, actualMailboxNumber);

            workerPool.ReleaseWorker(worker);
        }

        /// <summary>
        /// A test method that verifies the HandleFlaggedMail method places mail in the review queue.
        /// </summary>
        [TestMethod]
        public void HandleFlaggedMail_PlacesMailInReviewQueue()
        {
            // Arrange
            Person sender = new Person { Name = "John Doe", Address = "123 Sender St" };
            Person receiver = new Person { Name = "Jane Doe", Address = "456 Receiver St" };

            Mail flaggedMail = new Mail
            {
                Sender = sender,
                Receiver = receiver,
                IsFlagged = true
            };

            Worker.ReviewQueue = new List<Mail>(); // Ensure the ReviewQueue is initialized as a List<Mail>
            WorkerPool workerPool = new WorkerPool(1);

            Worker worker = workerPool.AcquireWorker();

            // Act
            worker.HandleFlaggedMail(flaggedMail);

            // Assert
            Assert.IsTrue(Worker.ReviewQueue.Contains(flaggedMail));

        }

        /// <summary>
        /// A test method that verifies the ProcessMail method dispatches mail to workers and releases to pool.
        /// </summary>
        [TestMethod]
        public void ProcessMail_DispatchesMailToWorkersAndReleasesToPool()
        {
            // Arrange
            Person sender = new Person { Name = "John Doe", Address = "123 Sender St" };
            Person receiver = new Person { Name = "Jane Doe", Address = "456 Receiver St" };

            Mail mail = new Mail
            {
                Sender = sender,
                Receiver = receiver
            };

            WorkerPool workerPool = new WorkerPool(1);

            MailDispatcher mailDispatcher = new MailDispatcher(workerPool);

            // Act
            mailDispatcher.ProcessMail(mail);

            // Assert
            Worker acquiredWorker = workerPool.AcquireWorker();
            Assert.IsNotNull(acquiredWorker);

        }

        /// <summary>
        /// A test method that verifies the WorkerPool creates a new worker when no available workers.
        /// </summary>
        [TestMethod]
        public void WorkerPool_CreatesNewWorkerWhenNoAvailableWorkers()
        {
            // Arrange
            WorkerPool workerPool = new WorkerPool(0);

            // Act
            Worker worker = workerPool.AcquireWorker();

            // Assert
            Assert.IsNotNull(worker);

        }
    }


}
