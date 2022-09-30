using System;

namespace LabEight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Nth Largest in an Array
            Console.WriteLine("Problem 1 - Nth Largest in an Array");
            Problem1 p1 = new Problem1();
            p1.NthLargest();

            // Problem 2 - Ordered Lists 
            Console.WriteLine("Problem 2 - Ordered Lists");
            Problem2 p2 = new Problem2();
            p2.OrderedList();

            // Problem 3 - Diverse Matrix
            Console.WriteLine("Problem 3 - Diverse Matrix");
            Problem3 p3 = new Problem3();
            p3.DiverseMatrix();
        }
    }
}
