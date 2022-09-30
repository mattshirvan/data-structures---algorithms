using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // QuickSort
            Console.WriteLine("QuickSort!");
            Sort<int> s = new Sort<int>();
            int[] A = { 2, 8, 7, 1, 5, 3, 6, 4 };
            s.QuickSort(A, 0, A.Length - 1);
            s.Print(A);
        }
    }
}
