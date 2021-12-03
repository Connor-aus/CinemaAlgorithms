using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class TicketSystem
    {
        private int freeMovie; // number of screenings before customer recieves a free ticket
        private int ticketPrice; // ticket price

        // check for screening availability and free ticket eligibility
        // must pass Cusomter and MovieScreenings object in order to increment screenings in object field
        public void TicketPurchase(ref MovieScreenings screenings, ref Customer aCustomer)
        {
            if (!screenings.Screenings[screenings.Head].IsFull()) // is the next screening full
            {
                screenings.Screenings[screenings.Head].AttendScreening(); // inreme
                Payment(ref aCustomer); // charge customer for ticket
            }
            else // next screening is full
            {
                Console.WriteLine("We're sorry" + aCustomer.FName + " but that screening is sold out. Please try again later.");
            }
        }

        // check for free ticket and charge customer
        private void Payment(ref Customer aCustomer)
        {
            if (aCustomer.Screenings == freeMovie) // has the customer attended enough screenings
            {
                Console.WriteLine("Congratualations " + aCustomer.FName + "! This ticket is free.");
                aCustomer.Screenings = 0; // reset customer screenings count
            }
            else // charge customer for ticket and print output
            {
                Console.WriteLine("Thank you " + aCustomer.FName + ", your purchase was successful. You have been charged $" + ticketPrice + " via " + aCustomer.PayMethod + " payment.");
                aCustomer.Screenings++;
            }
        }

        // constructor
        public TicketSystem()
        {
            freeMovie = 10; // set limit until free movie ticket is rewarded
            ticketPrice = 15;
        }
    }
}
