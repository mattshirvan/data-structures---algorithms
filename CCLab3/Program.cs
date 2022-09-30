using System;
/// <summary>
/// Worked Alone.
/// </summary>
namespace CCLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Microsoft interview question should return 4
            Problem1 p1 = new Problem1();
            int[] nums = { 1,1,2,2,3,3,4,5,5,6,6,7,7,8,8,9,9 };
            Console.WriteLine(p1.AppearTwice(nums));

            // Problem 2 - Reverse Words
            //Problem2 p2 = new Problem2();
            //String s = p2.WordSwap("Hello there children");
            //Console.WriteLine(s);

            // Problem 3 - Search: first larger than k
            //Problem3 p3 = new Problem3();
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int index = p3.LargerK(arr, 4, 0, 5);
            //Console.WriteLine(index);
        }
    }
}
