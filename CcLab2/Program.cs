using System;

namespace CcLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Palindrome Permutation
            //Problem1 p1 = new Problem1();
            //p1.PalindromePermutation("taco cat");

            // Problem 2 - Reverse Words
            //Problem2 p2 = new Problem2();
            //String s = p2.WordSwap("Hello there children");
            //Console.WriteLine(s);

            // Problem 3 - Search: first larger than k
            Problem3 p3 = new Problem3();
            int[] arr = { 1, 2, 3, 4, 5 };
            int index = p3.LargerK(arr, 4, 0, 5);
            Console.WriteLine(index);
        }
    }
}
