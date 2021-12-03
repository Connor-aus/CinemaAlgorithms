using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
	// invariants: every node’s left subtree contains values less than or equal to 
	// the node’s value, and every node’s right subtree contains values 
	// greater than or equal to the node’s value

	public interface IBSTree
    {
		// return true if the binary tree is empty; otherwise, return false. --what we guarantee to be true after the method is run
		bool IsEmpty();

		// item is added to the binary search tree
		void Insert(IComparable item);

		// an occurrence of item is removed from the binary search tree 
		// if item is in the binary search tree
		void Delete(IComparable item);

		// return true if item is in the binary search true;
		// otherwise, return false.
		bool Search(IComparable item);

		// all the nodes in the binary tree are visited once and there contents displayed
		// using in-order traversal
		void Display();

		// the binary tree becomes empty
		void Clear();
	}
}
