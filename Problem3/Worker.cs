using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    // Represents a worker responsible for processing mail and performing actions such as determining the mailbox, handling flagged mail, and returning to the dispatcher
    public class Worker
    {
        public static List<Mail> ReviewQueue = new List<Mail>();

        public int WorkerId { get; set; }

        // Method to determine the mailbox for the mail and return the assigned mailbox number
        public string DetermineMailbox(Mail mail)
        {
            // Example implementation: Assign the mail to a mailbox based on the receiver's address
            string mailboxNumber = mail.Receiver.Address.GetHashCode().ToString();
            Console.WriteLine($"Mail from {mail.Sender.Name} to {mail.Receiver.Name} has been placed in mailbox {mailboxNumber}.");
            return mailboxNumber;
        }

        // Method to handle flagged mail and place it in a review queue
        public void HandleFlaggedMail(Mail mail)
        {
            if (mail.IsFlagged)
            {
                // Add the mail to a review queue
                Console.WriteLine($"Flagged mail from {mail.Sender.Name} to {mail.Receiver.Name} has been placed in the review queue.");
                ReviewQueue.Add(mail);
            }
        }

        // Method to return to the dispatcher after processing the mail
        public void ReturnToDispatcher()
        {
            // Example implementation: Simulate the worker returning to the dispatcher
            Console.WriteLine($"Worker {WorkerId} has returned to the dispatcher.");
                // Notify the dispatcher that the worker is available for more work
            
        }
    }

}
