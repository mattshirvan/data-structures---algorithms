using System;

namespace CCLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Sorted Merge
            Console.WriteLine("Problem 1 - Sorted Merge");
            Problem1 p1 = new Problem1();
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] B = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            p1.printA(p1.Merge(A, B));

            // Problem 2 - Sparse Search
            Console.WriteLine("Problem 2 - Sparse Search");
            Problem2 p2 = new Problem2();
            string[] s = { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            Console.WriteLine(p2.SparseSearch("ball", s));
            Console.WriteLine();

            // Problem 3 - Peaks and Valleys
            Console.WriteLine("Problem 3 - Peaks and Valleys");
            Problem3 p3 = new Problem3();
            int[] A2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            p3.ValleyPeaks(A2);
        }
    }
}
