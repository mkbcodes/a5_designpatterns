using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    // Represents a mail object with common properties for sender, receiver, postal cost, weight, and a flag
    public class Mail
    {
        public Person Sender { get; set; }
        public Person Receiver { get; set; }
        public decimal PostalCost { get; set; }
        public double Weight { get; set; }
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

    // Represents a letter mail object that inherits from the Mail class and has an additional property for the number of pages
    public class Letter : Mail
    {
        public int NumberOfPages { get; set; }
    }

    // Represents a package mail object that inherits from the Mail class and has additional properties for dimensions
    public class Package : Mail
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }


}
