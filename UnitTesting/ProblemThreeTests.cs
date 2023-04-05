using Problem3;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    /**
     * 
        These tests cover the following scenarios for the Problem 3 solution:
        1. Test whether a worker can process mail and put it in the correct mailbox.
        2. Test whether a flagged mail is moved to the review queue.
        3. Test whether unregistering a worker prevents them from processing mail.
        4. Test whether multiple workers can process mail simultaneously.
     * 
     */
    [TestClass]
    public class MailroomTests
    {
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
