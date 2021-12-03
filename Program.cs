using System;
using System.Collections.Generic;
namespace Workshop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise an empty binary search tree called CustomerCollection
            // initialise an empty stack called MovieCollection
            // initialise an empty queue called TicketSystem
            // initialise ticket system
            CustomerCollection CC = new CustomerCollection();
            MovieCollection MC = new MovieCollection();
            MovieScreenings MS = new MovieScreenings();
            TicketSystem TS = new TicketSystem();
            
            // remove a customer when the BST is empty
            Console.WriteLine("Test 1");
            CC.Delete(new Customer("Andrew", "Adams", 12345612, "Visa"));

            // display empty BST - details of all customers using in-order traversal
            Console.WriteLine("Test 2");
            CC.Display();
            Console.ReadKey();

            //use the Insert method to insert five Cutomer objects into the BST 
            Console.WriteLine("Test 3");
            CC.Insert(new Customer("Andrew", "Adams", 44444444, "Visa"));
		    CC.Insert(new Customer("Bob", "Barneby", 22222222, "Mastercard"));
            CC.Insert(new Customer("Napoleon", "Short", 55555555, "Cash"));
            CC.Insert(new Customer("Clin", "Billton", 66666666, "Mastercard"));
            CC.Insert(new Customer("Tony", "Montana", 11111111, "Cash"));
            CC.Insert(new Customer("Anthony", "Soprano", 33333333, "Mastercard"));
            CC.Insert(new Customer("Jon", "Snow", 77777777, "Visa"));
            CC.Display();
            Console.ReadKey();

            // remove a customer that doesn't exist in the BST
            Console.WriteLine("Test 4");
            CC.Delete(new Customer("Andrew", "Adams", 12345612, "Visa"));
            CC.Display();
            Console.ReadKey();

            // delete a leaf node via phone number
            Console.WriteLine("Test 5");
            Customer aCustomer = new Customer(11111111);
            CC.Delete(aCustomer);
            CC.Display();
            Console.ReadKey();

            // insert the deleted node back to the BST
            Console.WriteLine("Test 6");
            CC.Insert(new Customer("Tony", "Montana", 11111111, "Cash"));
            CC.Display();
            Console.ReadKey();

            // delete a node with two children
            Console.WriteLine("Test 7");
            CC.Delete(new Customer(44444444));
            CC.Display();
            Console.ReadKey();

            // delete a node that has only one child
            Console.WriteLine("Test 8");
            CC.Delete(new Customer(66666666));
            CC.Display();
            Console.ReadKey();

            // insert a node that matches an existing node - therefore overiding it
            Console.WriteLine("Test 9");
            CC.Insert(new Customer("Bruce", "Wayne", 11111111, "Cash"));
            CC.Display();
            Console.ReadKey();

            // delete a node that has only one child
            Console.WriteLine("Test 10");
            CC.Delete(new Customer("Clin", "Billton", 66666666, "Mastercard"));
            CC.Display();
            Console.ReadKey();

            // search for exisiting customer via phone number only
            Console.WriteLine("Test 11");
            aCustomer = new Customer(44444444);
            bool search = CC.Search(aCustomer);
            if (search)
            {
                Console.WriteLine(aCustomer.ToString() + " is in the BST (searched via phone number)\n");
            }
            else
            {
                Console.WriteLine(aCustomer.ToString() + " is not in the BST (searched via phone number)\n");
            }

            // search for non-existent customer via phone number only
            Console.WriteLine("Test 12");
            aCustomer = new Customer(19283746);
            search = CC.Search(aCustomer);
            if (search)
            {
                Console.WriteLine(aCustomer.ToString() + " is in the BST (searched via phone number)\n");
            }
            else
            {
                Console.WriteLine(aCustomer.ToString() + " is not in the BST (searched via phone number)\n");
            }


            // clear the binary tree
            Console.WriteLine("Test 13");
            CC.Clear();
            CC.Display();
            Console.ReadKey();

            // trying to pop without any movies and display the stack of movies
            Console.WriteLine("Test 14");
            MC.Pop();
            MC.Display();
            Console.ReadKey();

            // adding movies to the movie list, pushing and popping
            Console.WriteLine("Test 15");
            MC.PushMovie(new Movie("The Lord of the Rings: Fellowship of the Ring"));
            MC.PushMovie(new Movie("Bravheart"));
            MC.PushMovie(new Movie("Gladiator"));
            MC.PushMovie(new Movie("No Country for old Men"));
            MC.PushMovie(new Movie("Rambo"));
            MC.PushMovie(new Movie("The Lord of the Rings: The Two Towers"));
            MC.PushMovie(new Movie("Anything with Nick Cage"));
            MC.Display();
            Console.ReadKey();


            // popping a movie
            Console.WriteLine("Test 16");
            MC.Pop();
            MC.Display();
            Console.ReadKey();


            // push and pop
            Console.WriteLine("Test 17");
            MC.PushMovie(new Movie("The Lord of the Rings: The Return of the King"));
            MC.Pop();
            MC.Display();
            Console.ReadKey();

            // play some movies when the stack is empty
            Console.WriteLine("Test 18");
            MC.Pop();
            MC.Pop();
            MC.Pop();
            MC.Pop();
            MC.Pop();
            MC.Pop();
            MC.Display();
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            // re-enter movies
            Console.WriteLine("Test 19");
            MC.PushMovie(new Movie("The Lord of the Rings: Fellowship of the Ring"));
            MC.PushMovie(new Movie("Bravheart"));
            MC.PushMovie(new Movie("Gladiator"));
            MC.PushMovie(new Movie("No Country for old Men"));
            MC.PushMovie(new Movie("Rambo"));
            MC.PushMovie(new Movie("The Lord of the Rings: The Two Towers"));
            MC.PushMovie(new Movie("Anything with Nick Cage"));
            MC.Display();
            Console.ReadKey();

            // showing screenings
            Console.WriteLine("Test 20");
            Console.WriteLine("\n-Monday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            Console.WriteLine("\n-Tuesday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            Console.WriteLine("\n-Wednesday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            Console.WriteLine("\n-Thursday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            // add movie to collection before all three screenings have finished
            Console.WriteLine("Test 21");
            MC.PushMovie(new Movie("----- New Movie"));
            MC.Display();

            Console.WriteLine("\n-Friday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            Console.WriteLine("\n-Saturday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            Console.WriteLine("\n-Sunday");
            Console.WriteLine("Sceening 1:");
            MS.ScreenMovie(ref MC);
            Console.WriteLine("Sceening 2:");
            MS.ScreenMovie(ref MC);
            Console.ReadKey();

            // display movies left in collection
            Console.WriteLine("Test 22");
            MC.Display();
            Console.ReadKey();

            // puchasing tickets until a free ticket is allocated
            Console.WriteLine("Test 23");
            CC.Insert(new Customer("Viewer", "One", 99999999, "Payment"));
            aCustomer = new Customer("Viewer", "One", 99999999, "Payment");
            
            // match object to customer in Customer Collection so that it can be reference for ticket purchase
            if (CC.Search(aCustomer))
            {
                CC.Match(ref aCustomer);
            }

            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            Console.ReadKey();

            // buy tickets for multuple cusomers
            Console.WriteLine("Test 24");
            Customer bCustomer = new Customer("OtherViewer", "Two", 11111111, "Example");
            CC.Insert(new Customer("OtherViewer", "Two", 11111111, "Example"));
            
            // match Customer to referrence in Customer Collection
            if (CC.Search(bCustomer))
            {
                CC.Match(ref bCustomer);
            }

            TS.TicketPurchase(ref MS, ref bCustomer);
            Console.WriteLine(bCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref bCustomer);
            Console.WriteLine(bCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            Console.ReadKey();

            // delete customer and insert customer again - check to make sure number of screenings in Customer object has reset
            Console.WriteLine("Test 25");
            CC.Delete(new Customer("Viewer", "One", 99999999, "Payment"));
            CC.Insert(new Customer("Viewer", "One", 99999999, "Payment"));
            aCustomer = new Customer("Viewer", "One", 99999999, "Payment");

            // match object to customer in Customer Collection so that it can be reference for ticket purchase
            if (CC.Search(aCustomer))
            {
                CC.Match(ref aCustomer);
            }

            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.WriteLine(aCustomer.ToString());
            TS.TicketPurchase(ref MS, ref aCustomer);
            Console.ReadKey();
            
            


            // EFFICIENCY FUNCTIONS

            //calculate efficiency of BST Insert()
            Console.WriteLine("EF for BST Insert():");
            CC = new CustomerCollection();
            BSTEfficiencyINSERT(1, ref CC);
            BSTEfficiencyINSERT(10, ref CC);
            BSTEfficiencyINSERT(50, ref CC);
            BSTEfficiencyINSERT(100, ref CC);
            BSTEfficiencyINSERT(150, ref CC);
            BSTEfficiencyINSERT(200, ref CC);
            BSTEfficiencyINSERT(250, ref CC);
            BSTEfficiencyINSERT(300, ref CC);
            BSTEfficiencyINSERT(350, ref CC);
            BSTEfficiencyINSERT(400, ref CC);
            Console.WriteLine();

            //calculate efficiency of BST Delete()
            Console.WriteLine("EF for BST Delete():");
            CC = new CustomerCollection();
            BSTEfficiencyDELETE(1, ref CC);
            BSTEfficiencyDELETE(10, ref CC);
            BSTEfficiencyDELETE(50, ref CC);
            BSTEfficiencyDELETE(100, ref CC);
            BSTEfficiencyDELETE(150, ref CC);
            BSTEfficiencyDELETE(200, ref CC);
            BSTEfficiencyDELETE(250, ref CC);
            BSTEfficiencyDELETE(300, ref CC);
            BSTEfficiencyDELETE(350, ref CC);
            BSTEfficiencyDELETE(400, ref CC);
            Console.WriteLine();

            //calculate efficiency of BST Display()
            Console.WriteLine("EF for BST Display():");
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(1, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(10, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(50, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(100, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(150, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(200, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(250, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(300, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(350, ref CC);
            CC = new CustomerCollection();
            BSTEfficiencyDISPLAY(400, ref CC);
            Console.WriteLine();

            //calculate efficiency of BST Search()
            Console.WriteLine("EF for BST Search():");
            CC = new CustomerCollection();
            BSTEfficiencySEARCH(1, ref CC);
            BSTEfficiencySEARCH(10, ref CC);
            BSTEfficiencySEARCH(50, ref CC);
            BSTEfficiencySEARCH(100, ref CC);
            BSTEfficiencySEARCH(150, ref CC);
            BSTEfficiencySEARCH(200, ref CC);
            BSTEfficiencySEARCH(250, ref CC);
            BSTEfficiencySEARCH(300, ref CC);
            BSTEfficiencySEARCH(350, ref CC);
            BSTEfficiencySEARCH(400, ref CC);
            Console.WriteLine();
            
            //calculate efficiency of Stack Push()
            Console.WriteLine("EF for Stack Push():");
            MC = new MovieCollection();
            StackEfficiencyPUSH(1, ref MC);
            StackEfficiencyPUSH(10, ref MC);
            StackEfficiencyPUSH(50, ref MC);
            StackEfficiencyPUSH(100, ref MC);
            StackEfficiencyPUSH(150, ref MC);
            StackEfficiencyPUSH(200, ref MC);
            StackEfficiencyPUSH(250, ref MC);
            StackEfficiencyPUSH(300, ref MC);
            StackEfficiencyPUSH(350, ref MC);
            StackEfficiencyPUSH(400, ref MC);
            Console.WriteLine();

            //calculate efficiency of Stack Pop()
            Console.WriteLine("EF for Stack Pop():");
            MC = new MovieCollection();
            StackEfficiencyPOP(1, ref MC);
            StackEfficiencyPOP(10, ref MC);
            StackEfficiencyPOP(50, ref MC);
            StackEfficiencyPOP(100, ref MC);
            StackEfficiencyPOP(150, ref MC);
            StackEfficiencyPOP(200, ref MC);
            StackEfficiencyPOP(250, ref MC);
            StackEfficiencyPOP(300, ref MC);
            StackEfficiencyPOP(350, ref MC);
            StackEfficiencyPOP(400, ref MC);
            Console.WriteLine();

            //calculate efficiency of Stack Display()
            Console.WriteLine("EF for Stack Display():");
            StackEfficiencyDISPLAY(1, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(10, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(50, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(100, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(150, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(200, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(250, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(300, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(350, ref MC);
            MC = new MovieCollection();
            StackEfficiencyDISPLAY(400, ref MC);
            Console.WriteLine();


            //calculate efficiency of Queue Enqueue()
            Console.WriteLine("EF for Stack Enqueue():");
            StackEfficiencyPUSH(400, ref MC);
            MS = new MovieScreenings();
            StackEfficiencyENQUEUE(1, ref MS, ref MC);
            StackEfficiencyENQUEUE(10, ref MS, ref MC);
            StackEfficiencyENQUEUE(50, ref MS, ref MC);
            StackEfficiencyENQUEUE(100, ref MS, ref MC);
            StackEfficiencyENQUEUE(150, ref MS, ref MC);
            StackEfficiencyENQUEUE(200, ref MS, ref MC);
            StackEfficiencyENQUEUE(250, ref MS, ref MC);
            StackEfficiencyENQUEUE(300, ref MS, ref MC);
            StackEfficiencyENQUEUE(350, ref MS, ref MC);
            StackEfficiencyENQUEUE(400, ref MS, ref MC);
            Console.WriteLine();

            Console.WriteLine();//calculate efficiency of Queue Dequeue()
            Console.WriteLine("EF for Stack Dequeue():");
            MS = new MovieScreenings();
            StackEfficiencyDEQUEUE(1, ref MS, ref MC);
            StackEfficiencyDEQUEUE(10, ref MS, ref MC);
            StackEfficiencyDEQUEUE(50, ref MS, ref MC);
            StackEfficiencyDEQUEUE(100, ref MS, ref MC);
            StackEfficiencyDEQUEUE(150, ref MS, ref MC);
            StackEfficiencyDEQUEUE(200, ref MS, ref MC);
            StackEfficiencyDEQUEUE(250, ref MS, ref MC);
            StackEfficiencyDEQUEUE(300, ref MS, ref MC);
            StackEfficiencyDEQUEUE(350, ref MS, ref MC);
            StackEfficiencyDEQUEUE(400, ref MS, ref MC);
            Console.WriteLine();

            Console.ReadLine();

            TS = new TicketSystem();

            //calculate efficiency of BST Insert()
            void BSTEfficiencyINSERT(int n, ref CustomerCollection CC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates

                // input n customers each with random number
                for (int i = 0; i < n; i++)
                {
                    int randoms = _random.Next(min, max);
                    CC.Insert(new Customer(randoms));
                }

                int test = _random.Next(min, max);
                
                CC.insertCount = 0;

                CC.Insert(new Customer(test));

                Console.WriteLine("n = " + n + "   efficiency = " + CC.insertCount);
            }

            //calculate efficiency of BST Delete()
            void BSTEfficiencyDELETE(int n, ref CustomerCollection CC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates

                // input n customers each with random number
                for (int i = 0; i < (n-1); i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    CC.Insert(new Customer(randoms));
                }
                
                CC.deleteCount = 0;

                CC.Insert(new Customer(5000));
                CC.Delete(new Customer(5000));

                Console.WriteLine("n = " + n + "   efficiency = " + CC.deleteCount);
            }

            //calculate efficiency of BST Display()
            void BSTEfficiencyDISPLAY(int n, ref CustomerCollection CC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates

                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    CC.Insert(new Customer(randoms));
                }
                
                CC.DisplayBlank(); // the same function but does not display customer details

                Console.WriteLine("n = " + n + "   efficiency = " + CC.displayCount);
            }

            //calculate efficiency of BST Search()
            void BSTEfficiencySEARCH(int n, ref CustomerCollection CC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates

                // input n customers each with random number
                for (int i = 0; i < (n - 1); i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    CC.Insert(new Customer(randoms));
                }
                
                CC.deleteCount = 0;

                CC.Insert(new Customer(5000));
                CC.Search(new Customer(5000));

                Console.WriteLine("n = " + n + "   efficiency = " + CC.searchCount);
            }

            //calculate efficiency of Stack Push()
            void StackEfficiencyPUSH(int n, ref MovieCollection MC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates


                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    MC.PushMovie(new Movie(Convert.ToString(randoms)));
                }

                MC.pushCount = 0;

                MC.PushMovie(new Movie("Example"));

                Console.WriteLine("n = " + n + "   efficiency = " + MC.pushCount);
            }

            //calculate efficiency of Stack Pop()
            void StackEfficiencyPOP(int n, ref MovieCollection MC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates


                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    MC.PushMovie(new Movie(Convert.ToString(randoms)));
                }

                MC.popCount = 0;

                MC.Pop();

                Console.WriteLine("n = " + n + "   efficiency = " + MC.popCount);
            }

            //calculate efficiency of Stack Display()
            void StackEfficiencyDISPLAY(int n, ref MovieCollection MC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates


                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    MC.PushMovie(new Movie(Convert.ToString(randoms)));
                }

                MC.displayCount = 0;

                MC.DisplayBlank();

                Console.WriteLine("n = " + n + "   efficiency = " + MC.displayCount);
            }

            //calculate efficiency of Queue Enqueue()
            void StackEfficiencyENQUEUE(int n, ref MovieScreenings MS, ref MovieCollection MC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates


                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    MC.PushMovie(new Movie(Convert.ToString(randoms)));
                }

                MS.ScreenMovie(ref MC); // ensure then is a nextMovie to enqueue

                MS.enqueueCount = 0;

                MS.Enqueue();

                Console.WriteLine("n = " + n + "   efficiency = " + MS.enqueueCount);
            }

            //calculate efficiency of Queue Dequeue()
            void StackEfficiencyDEQUEUE(int n, ref MovieScreenings MS, ref MovieCollection MC)
            {
                // random number generator
                Random _random = new Random();
                int min = -100000;
                int max = 100000; // should provide no to little duplicates


                // input n customers each with random number
                for (int i = 0; i < n; i++) // n-1 is used because a customer customer that can be deleted is also added
                {
                    int randoms = _random.Next(min, max);
                    MC.PushMovie(new Movie(Convert.ToString(randoms)));
                }

                MS.ScreenMovie(ref MC); // ensure then is a nextMovie to enqueue


                MS.dequeueCount = 0;

                MS.Dequeue();

                Console.WriteLine("n = " + n + "   efficiency = " + MS.dequeueCount);
            }
        }
    }
}
