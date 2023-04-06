using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Mail
    {
        /// <summary>
        /// Gets or sets the sender of the mail.
        /// </summary>
        public Person? Sender { get; set; }

        /// <summary>
        /// Gets or sets the receiver of the mail.
        /// </summary>
        public Person? Receiver { get; set; }

        /// <summary>
        /// Gets or sets the postal cost of the mail.
        /// </summary>
        public decimal PostalCost { get; set; }

        /// <summary>
        /// Gets or sets the weight of the mail.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets a flag to indicate whether the mail is flagged or not.
        /// </summary>
        public bool IsFlagged { get; set; }
    }

}
