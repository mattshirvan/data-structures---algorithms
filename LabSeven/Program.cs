using System;
using System.Collections.Generic;
using System.Collections;
namespace LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Tree<int> t = new Tree<int>();


            // Problem 2- Minimal Height (First to populate tree)
            Console.WriteLine("Problem 2- Minimal Height");
            Node<int> root = t.MinHeight(arr);
            t.PreOrderTraversal(root);
            Console.WriteLine();

            // Problem 1 - List of Depths
            Console.WriteLine("Problem 1 - List of Depths");
            var results = t.ListofDepths(root);
            foreach (var result in results)
            {
                foreach (var lists in result)
                {
                    Console.WriteLine(lists.Value);
                }
            }
            Console.WriteLine();

            

            // Problem 3 - Path between nodes
            Console.WriteLine("Problem 3 - Path between nodes");
            t.PrintAllPaths(root.Right, root.Right.Right.Right);
            Console.WriteLine();
        }
    }
}
