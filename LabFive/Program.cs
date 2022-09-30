using System;
using System.Collections.Generic;
using System.IO;
namespace LabFive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Reverse Queue with Stack
            Console.WriteLine("Problem 1: Reverse Queue with Stack");
            Stack<int> S = new Stack<int>();
            Queue<int> Q = new Queue<int>();
            Problem1 p1 = new Problem1();

            // Enqueue elements
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.Enqueue(5);
            Q.Enqueue(6);

            //p1.ReverseQ(S, Q); --- Iterative
            p1.PrintQ(Q);
            p1.ReverseQ2(S, Q); // Recursive
            p1.PrintQ(Q);

            // Problem 2 - Reverse File with Stack
            Problem2 p2 = new Problem2();
            
            // Get input file from user
            Console.WriteLine("Enter input file: ");
            string input = Console.ReadLine();

            // Get output file from user
            Console.WriteLine("Enter output file: ");
            string output = Console.ReadLine();
            p2.ReverseFile(Directory.GetCurrentDirectory() + "\\" + input, Directory.GetCurrentDirectory() + "\\" + output);

            // Problem 3 - Queue From Two Stacks
            Problem3<int> p3 = new Problem3<int>();

            // Enqueue elements
            p3.Enqueue(1);
            p3.Enqueue(2);
            p3.Enqueue(3);
            p3.Enqueue(4);
            p3.Enqueue(5);
            p3.Enqueue(6);
            p3.PrintQ();
        }
    }
}
