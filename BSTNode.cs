using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
    //Class to represent tree nodes
    public class BSTNode
    {
        public IComparable Item { get; set; }         //data item
        public BSTNode LChild { get; set; } //reference to left child (less than this node)
        public BSTNode RChild { get; set; } //reference to right child (greater than this node)

        //Constructor
        public BSTNode(IComparable item)
        {
            Item = item;
            LChild = null;
            RChild = null;
        }
    }
}
