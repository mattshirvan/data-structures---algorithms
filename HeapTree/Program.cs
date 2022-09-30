using System;

namespace HeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = { 1, 2, 3, 4, 5, 6 };
            int temp = A[0];
            A[0] = A[A.Length-1];
        }
    }
}
