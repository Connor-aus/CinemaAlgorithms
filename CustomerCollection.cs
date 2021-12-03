using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_3
{
	public class CustomerCollection : IBSTree
	{
		private BSTNode root; // root node
		public BSTNode lastSearched; // save the last searched node.

		// counters for efficiency
		public int insertCount = 0;
		public int deleteCount = 0;
		public int searchCount = 0;
		public int displayCount = 0;

		// returns true if root == null
		public bool IsEmpty()
		{
			return root == null;
		}

		// insert customer into BST
		public void Insert(IComparable item)
		{
			if (root == null) // BST is empty
			{
				root = new BSTNode(item);
			}
			else
			{
				Insert(item, root); // pass to recursive insert function
			}
		}
		// recursive element of insert
		private void Insert(IComparable item, BSTNode node)
		{
			insertCount++;

			if (item.CompareTo(node.Item) == 0) // customer exists - overwrite
			{
				node.Item = item;
				return;
			}
			if (item.CompareTo(node.Item) < 0) // customer is smaller - move to left child
			{
				if (node.LChild == null)
				{
					node.LChild = new BSTNode(item);
				}
				else
				{
					Insert(item, node.LChild);
				}
			}
			else // customer is smaller - move to right child
			{
				if (node.RChild == null)
				{
					node.RChild = new BSTNode(item);
				}
				else
				{
					Insert(item, node.RChild);
				}
			}
		}

		// delete via customer object
		public void Delete(IComparable item)
		{
			deleteCount++;

			// search for item and its parent
			BSTNode node = root; // search reference
			BSTNode parent = null; // parent of node
			while ((node != null) && (item.CompareTo(node.Item) != 0))
			{
				deleteCount++;
				parent = node;
				if (item.CompareTo(node.Item) < 0) // move to the left child of node
				{
					node = node.LChild;
				}
				else
				{
					node = node.RChild;
				}
			}

			if (node != null) // if the search was successful
			{
				// case 1: item has two children
				if ((node.LChild != null) && (node.RChild != null))
				{
					// find the right-most node in left subtree of node
					if (node.LChild.RChild == null) // a special case: the right subtree of node.LChild is empty
					{
						node.Item = node.LChild.Item;
						node.LChild = node.LChild.LChild;
					}
					else
					{
						BSTNode p = node.LChild;
						BSTNode pp = node; // parent of p
						while (p.RChild != null)
						{
							deleteCount++;

							pp = p;
							p = p.RChild;
						}
						// copy the item at p to node
						node.Item = p.Item;
						pp.RChild = p.LChild;
					}
				}
				else // cases 2 & 3: item has no or only one child
				{
					BSTNode c;
					if (node.LChild != null)
						c = node.LChild;
					else
						c = node.RChild;

					// remove node and replace parents child node
					if (node == root) //need to change root
						root = c;
					else
					{
						if (node == parent.LChild)
							parent.LChild = c;
						else
							parent.RChild = c;
					}
				}
			}
			else // customer not found in BST
			{
				Console.WriteLine("That entry was not found and no data was removed.");
			}
		}

		// search for customer
		public bool Search(IComparable item)
		{
			return Search(item, root); // pass to recursive element of function
		}

		// recursive element of Search()
		private bool Search(IComparable item, BSTNode node)
		{
			searchCount++;

			if (node != null)
			{
				if (item.CompareTo(node.Item) == 0) // customer found
                {
					Console.WriteLine("Customer found.\n");
					lastSearched = node; // save so searched customer can be referrenced
					return true;
                }
				else
                {
					if (item.CompareTo(node.Item) < 0) // check left child
                    {
						return Search(item, node.LChild);
                    }
					else
					{
						return Search(item, node.RChild); // check right child
					}
                }
			}
			else // customer not found
            {
				Console.WriteLine("Customer not found.\n");
				return false;
            }
		}

		// used to reference existing customer after successful search
		// customer can be referenced directly when puchasing a ticket and completing other functions
		public void Match(ref Customer customer)
        {
			customer = (Customer)lastSearched.Item;
		}

		// display all customer details in order
		public void Display()
		{
			if (root == null) // BST empty
			{
				Console.WriteLine("There are no customers in the system.\n");
				return;
			}
			Console.Write("Customer Details:\n");
			Display(root); // pass to recursive element of function
			Console.WriteLine();
		}

		// recursive element of Display() -  in-order traversal
		private void Display(BSTNode node)
		{
			if (node != null)
			{
				Display(node.LChild); // display all left children first
				Console.Write(node.Item);
				Display(node.RChild);
			}
		}

		// empty the BST
		public void Clear()
		{
			root = null;
			lastSearched = null;
		}

		// constructor
		public CustomerCollection()
		{
			root = null;
		}





		// USED ONLY FOR EFFICIENCY METHOD
		public void DisplayBlank()
		{
			if (root == null) // BST empty
			{
				Console.WriteLine("There are no customers in the system.\n");
				return;
			}
			//Console.Write("Customer Details:\n");
			DisplayBlank(root); // pass to recursive element of function
			//Console.WriteLine();
		}

		private void DisplayBlank(BSTNode node)
		{
			displayCount++;
			if (node != null)
			{

				DisplayBlank(node.LChild); // display all left children first
				//Console.Write(node.Item);
				DisplayBlank(node.RChild);
			}
		}
	}
}
