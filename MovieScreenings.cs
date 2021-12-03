using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class MovieScreenings : IQueue
    {
        private Screening[] screenings; // array of screenings (queue)
        private int head; // head of queue
        private int tail; // tail of queue
        private int count; // number of screenings queued with a movie
        private Movie nextMovie; // save newly popped movie for enqueueing

        public int enqueueCount = 0;
        public int dequeueCount = 0;

        // properties
        public Screening[] Screenings
        {
            get
            {
                return screenings;
            }
        }
        public int Head
        {
            get
            {
                return head;
            }
        }

        // enqueue movies -  called by the ScreenMovie function
        public void Enqueue()
        {
            if (nextMovie == null) // if there were no movies in the collection to enqueue
            {
                return;
            }

            while (!IsFull()) //enqueue until all 3 screening in queue are set
            {
                enqueueCount++;

                if (tail == (screenings.Length -1)) // shift tail front of array if at the end
                {
                    tail = 0;
                }
                else
                {
                    tail++;
                }
                
                if (screenings[tail] == null) // only used to create the screenings for the first time
                {
                    screenings[tail] = new Screening();
                    screenings[tail].Item = nextMovie;
                }
                else
                {
                    screenings[tail].Clear(); // used to clear movie and seats left in screening
                    screenings[tail].Item = nextMovie;
                }

                count++;
            }
        }

        // return true is the screenings are empty
        public bool IsEmpty()
        {
            return count == 0;
        }

        // output a movie
        public void Dequeue()
        {
            dequeueCount++;

            Console.WriteLine("Now playing: " + screenings[head].Item);
            screenings[head].Item = null;
            count--;

            // move head back a position
            if (head == screenings.Length - 1) // is head is at end of array move to start
            {
                head = 0;
            }
            else
            {
                head++;
            }
        }

        // necessary method to ensure Enqueue() and Dequeue take no parameters and can properly implement interface
        public void ScreenMovie(ref MovieCollection MC)
        {
            if (IsEmpty())
            {
                nextMovie = (Movie)MC.Pop(); // pop and save next movie from stack
                Enqueue();
            }
            if (nextMovie != null)
            {
                Dequeue();
            }
        }

        // return true if all screenings are queued with a movie
        public bool IsFull()
        {
            return count == (screenings.Length);
        }

        // set the class to read empty
        public void Clear()
        {
            count = 0;
        }

        // constructor
        public MovieScreenings()
        {
            screenings = new Screening[3]; // number of screenings
            head = 0;
            tail = 0;
            count = 0;
            nextMovie = null;
        }
    }
}
