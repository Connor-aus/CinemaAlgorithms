using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class MovieCollection : IStack
    {
        private LLNode top; //stack is implimented using a linked list
        private Movie newMovie; // saves new movie ready to be pushed

        public int pushCount = 0;
        public int popCount = 0;
        public int displayCount = 0;

        // put new movie on top of the stack
        public void Push()
        {
            pushCount++;

            if (top == null) // if stack if empty
            {
                top = new LLNode(newMovie);
            }
            else // pushes new node onto top of stack
            {
                LLNode node = new LLNode(newMovie);
                node.Pointer = top;
                top = node;
            }
        }

        // necessary method to ensure Push() takes no parameters and can properly implement interface
        public void PushMovie(Object newM)
        {
            newMovie = (Movie)newM;
            Push();
        }

        // removes and the node and passes the movie located at the movie of the stack
        public object Pop()
        {
            popCount++;

            if (top == null) // stack is empty
            {
                Console.WriteLine("There are no movies in the Collection\n");
                return null;
            }
            else
            {
                LLNode node = top;
                top = top.Pointer;
                return node.Item;
            }
        }

        // method for printing each movie
        public void Display()
        {
            Console.Write("Movie Collection:\n");
            Display(top); // pass to recursive element of the function
        }

        // recursive element of the Display() function
        public void Display(LLNode node)
        {
            if (node != null) // stack is empty
            {
                Console.Write(node.Item);
                Display(node.Pointer); // invoke again with next node
            }
            else
            {
                Console.WriteLine(); // to provide a linebreak at the end of Display()
            }
        }

        // returns true is there are no movies in the stack
        public bool IsEmpty()
        {
            return top == null;
        }

        // constructor
        public MovieCollection()
        {
            top = null;
            newMovie = null;
        }





        // USE FOR EFFICIENCY FUNCTION ONLY
        public void DisplayBlank()
        {
            //Console.Write("Movie Collection:\n");
            DisplayBlank(top); // pass to recursive element of the function
        }

        // recursive element of the Display() function
        public void DisplayBlank(LLNode node)
        {
            if (node != null) // stack is empty
            {
                displayCount++;

                //Console.Write(node.Item);
                DisplayBlank(node.Pointer); // invoke again with next node
            }
            else
            {
                //Console.WriteLine(); // to provide a linebreak at the end of Display()
            }
        }
    }
}
