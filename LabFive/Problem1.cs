using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFive
{
    class Problem1
    {
        /*
         * Problem 1 [30 points] Let Q be a non-empty queue, and let S be an empty stack. 
         * Write a C# program that reverses the order of the elements in Q, using S. 
         * Make sure to include running and space complexity for your code.
            Example: if initially the order of the objects in Q is 1,2,3,4,5,6, 
            then after reversing the objects, the order of the objects in Q is 6,5,4,3,2,1.
         */

        // time: O(n) space: O(n) iterative
        public void ReverseQ(Stack<int> S, Queue<int> Q)
        {
            // Print before reversal
            PrintQ(Q);

            // Dequeue and push to stack
            while (Q.Count > 0)
            {

                S.Push(Q.Dequeue());
            }

            // Pop from stack and enqueue
            while (S.Count > 0)
            {
                Q.Enqueue(S.Pop());
            }

            // Print to show reversal
            PrintQ(Q);
        }

        // time: O(n) space: O(n) Recursive
        public void ReverseQ2(Stack<int> S, Queue<int> Q)
        {
            // Base Case
            if (Q.Count <= 0)
            {
                // Call pop from stack and enqueue
                ReverseS(S, Q);
                return;
            }

            // Dequeue and push to stack
            S.Push(Q.Dequeue());

            // Recursive call
            ReverseQ2(S, Q);
        }

        public void ReverseS(Stack<int> S, Queue<int> Q)
        {
            // Base case
            if (S.Count <= 0)
            {
                return;
            }

            // Pop from stack and enqueue
            Q.Enqueue(S.Pop());

            // Recursive call
            ReverseS(S, Q);
        }

        public void PrintQ(Queue<int> Q)
        {
            // Iterate over queue and print
            foreach (int v in Q)
            {
                Console.WriteLine(v); 
            }
        }
    }
}
