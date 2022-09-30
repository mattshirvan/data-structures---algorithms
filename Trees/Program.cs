using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem 1 - Non Leaf Count O(n)
            Console.WriteLine("Problem 1 - Non Leaf Count");
            Tree<int> t1 = new Tree<int>();
            t1.Insert(10);
            t1.Insert(12);
            t1.Insert(11);
            t1.Insert(17);
            t1.Insert(15);
            t1.Insert(3);
            t1.Insert(5);
            t1.Insert(4);
            t1.Insert(1);
            t1.Insert(1);
            t1.Insert(2);
            
            Console.WriteLine($"Size:{t1.size(t1.Root)}, Non-Leaf: {t1.CountNonLeafNodes()}, Leaves: {t1.CountLeafNodes()}");
            Console.WriteLine();

            // Problem 2 - Value Count O(n)
            Console.WriteLine("Problem 2 - Value Count");
            Tree<int> t2 = new Tree<int>();
            t2.Insert(1);
            t2.Insert(1);
            t2.Insert(1);
            t2.Insert(2);
            t2.Insert(2);
            t2.Insert(3);

            // Check value count
            Console.WriteLine(t2.SearchValueCount(2)); // should return 2
            Console.WriteLine(t2.SearchValueCount(1)); // should return 3
            Console.WriteLine();

            // Problem 3 - Valid BST O(n)
            Console.WriteLine("Problem 3 - Valid BST");
            Tree<int> t = new Tree<int>();
            t.Insert(3);
            t.Insert(1);
            t.Insert(2);

            // Preorder traversal
            t.InOrderTraversal(t.Root);

            // Check valid for any tree given root/node
            Console.WriteLine(t.Valid(t.Root));
            Console.WriteLine();

            // Problem 4 - Nth Largest O(n)
            Console.WriteLine("Problem 4 - Nth Largest");
            t1.NthLargest(t1.Root, 3); // input: n = 3 output: 12; input: n = 4 output: 11
        }
    }
}
