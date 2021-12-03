using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class Screening
    {
        public Object Item { get; set; } // movie being played
        private int seats = 50; // number of seats availble for screening
        private int seatsLeft; // number of seats left for this screening

        // decrement availble seats
        public void AttendScreening()
        {
            seatsLeft--; // doesn't matter if available seats decrements below 0
        }

        // returns true if there are no seats available for this screening
        public bool IsFull()
        {
            return seatsLeft <= 0;
        }

        // reset screening
        public void Clear()
        {
            Item = null;
            seatsLeft = seats;
        }

        //constructor
        public Screening()
        {
            Item = null; // movie
            seatsLeft = seats; // set available seats for screening
        }
    }
}
