using System;

namespace CCLab5
{
    class Program
    {
        /*
          How would you design a stack which, in addition to push and pop, 
        has a function min which returns the minimum element? 
        Push, pop and min should all operate in 0(1) time.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Stack Min Problem");
            Stack<int> s = new Stack<int>(3);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);

            Console.WriteLine(s.min);
        }
    }
}
