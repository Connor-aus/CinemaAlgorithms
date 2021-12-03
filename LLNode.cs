using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    public class LLNode
    {
        public Object Item { get; set; } // data in node
        public LLNode Pointer { get; set; } // pointer to next node

        // constructor
        public LLNode(Object item)
        {
            Item = item;
            Pointer = null;
        }
    }
}
