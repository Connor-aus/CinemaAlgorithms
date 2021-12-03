using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public interface IQueue
    {
        // return true if the queue is empty
        bool IsEmpty();

        // add an item to the end of the queue and move the tail
        void Enqueue();

        // remove the first item from the queue and move the head
        void Dequeue();

        // return true if the queue is full
        bool IsFull();

        // post: the queue becomes empty
        void Clear();
    }
}
