﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    /// <summary>
    /// Represents a worker responsible for processing mail and performing actions such as determining the mailbox, handling flagged mail, and returning to the dispatcher
    /// </summary>
    public class Worker
    {
        public IDispatcherObserver DispatcherObserver { get; set; }
        public static List<Mail> ReviewQueue = new List<Mail>();

        /// <summary>
        /// Gets or sets the ID of the worker.
        /// </summary>
        public int WorkerId { get; set; }

        /// <summary>
        /// Determines the mailbox for the mail and returns the assigned mailbox number.
        /// </summary>
        /// <param name="mail">A Mail object.</param>
        /// <returns>A string representing the mailbox number.</returns>
        public string DetermineMailbox(Mail mail)
        {
            if (mail == null || mail.Receiver == null || mail.Receiver.Address == null)
            {
                throw new ArgumentException("Mail, receiver, or receiver's address cannot be null.");
            }

            string mailboxNumber = mail.Receiver.Address;

            return mailboxNumber;
        }


        /// <summary>
        /// Handles flagged mail and places it in a review queue.
        /// </summary>
        /// <param name="mail">A Mail object.</param>
        public void HandleFlaggedMail(Mail mail)
        {
            if (mail == null)
            {
                throw new ArgumentException("Mail object cannot be null.");
            }

            if (mail.IsFlagged)
            {
                // Add the mail to a review queue
                Console.WriteLine($"Flagged mail from {mail.Sender.Name} to {mail.Receiver.Name} has been placed in the review queue.");
                ReviewQueue.Add(mail);
            }
        }


        /// <summary>
        /// Returns to the dispatcher after processing the mail.
        /// </summary>
        public void ReturnToDispatcher()
        {
            // Notify the dispatcher that the worker is available for more work
            DispatcherObserver.OnWorkerAvailable(this);
        }
    }

}
