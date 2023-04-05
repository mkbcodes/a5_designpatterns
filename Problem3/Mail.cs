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
        public Person Sender { get; set; }

        /// <summary>
        /// Gets or sets the receiver of the mail.
        /// </summary>
        public Person Receiver { get; set; }

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

    /// <summary>
    /// Represents a person with name and address properties.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of the person.
        /// </summary>
        public string Address { get; set; }
    }

    /// <summary>
    /// Represents a letter mail object that inherits from the Mail class and has an additional property for the number of pages.
    /// </summary>
    public class Letter : Mail
    {
        /// <summary>
        /// Gets or sets the number of pages of the letter.
        /// </summary>
        public int NumberOfPages { get; set; }
    }

    /// <summary>
    /// Represents a package mail object that inherits from the Mail class and has additional properties for dimensions.
    /// </summary>
    public class Package : Mail
    {
        /// <summary>
        /// Gets or sets the length of the package.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets the width of the package.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the package.
        /// </summary>
        public double Height { get; set; }
    }

}
