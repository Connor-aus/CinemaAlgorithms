using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class Customer : IComparable
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Mobile { get; set; } // assumed that all numbers include only integers
        public string PayMethod { get; set; }
        public int Screenings { get; set; } // number of screenings a customer has attended

        // constructor
        public Customer (string fName, string lName, int num, string pay)
        {
            FName = fName;
            LName = lName;
            Mobile = num;
            PayMethod = pay;
            Screenings = 0; // add customer before entering first movie
        }

        // constructor -- for comparisons
        public Customer(int num)
        {
            Mobile = num;

            // only the phone number is used for comparison
            FName = "-";
            LName = "-";
            PayMethod = "-";
            Screenings = 0;
        }

        // when displaying customer details
        public override string ToString()
        {
            return ("Name: " + FName + " " + LName + ", Phone: " + Mobile + ", Payment: " + PayMethod + ", Screenings: " + Screenings + "\n");
        }

        // for comparing customers
        public int CompareTo(Object obj)
        {
            Customer person = (Customer)obj;
            if (this.Mobile.CompareTo(person.Mobile) < 0)
            {
                return -1;
            }
            else if (this.Mobile.CompareTo(person.Mobile) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
