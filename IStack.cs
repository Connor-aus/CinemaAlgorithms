using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public interface IStack
    {
        // return true if the stack is empty
        bool IsEmpty();

        // adds an element to the top of the stack
        void Push();

        // returns the element from the top of the stack and removes it
        object Pop();

        // display all items in the stack
        void Display();
    }
}
