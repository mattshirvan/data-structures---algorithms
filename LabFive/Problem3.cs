using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFive
{
    class Problem3<T>
    {
        /*
         * Problem 3 [40 points] Implement a Queue class using two stacks 
         * (for hints, see problem 3.4/page 99 from "Cracking the coding interviews..."). 
         * What is the running time for enqueue() and dequeue()? Make your classes generic. 
         * Make sure to include running and space complexity for your methods.
         */

        public Stack<T> S1 { get; set; }
        public Stack<T> S2 { get; set; }

        // O(1)
        public void Enqueue(T Value)
        {
            // Add to queue buffer
            S1.Push(Value);
        }

        // O(n)
        public T Dequeue()
        {
            if (Empty())
            {
                throw new Exception("Can't remove from an empty queue");
            }

            Swap(S1, S2); // move from storage to buffer

            var ret = S2.Pop();

            Swap(S1, S2); // move buffer to storage

            return ret;
        }

        // O(n)
        public T Peek()
        {
            if (Empty())
            {
                throw new Exception("Can't peek at an empty queue");
            }

            Swap(S1, S2); // move from storage to buffer

            var ret = S2.Peek();

            Swap(S1, S2); // move buffer to storage

            return ret;
        }

        // O(1)
        public bool Empty()
        {
            return S1.Count <= 0 && S2.Count <= 0;
        }

        // O(n)
        public void PrintQ()
        {
            Swap(S1, S2); // move from storage to buffer

            // Iterate over queue and print
            foreach (var v in S2)
            {
                Console.WriteLine(v);
            }

            Swap(S1, S2); // move buffer to storage
        }

        // O(n) - helper function
        private void Swap(Stack<T> a, Stack<T> b)
        {
            while (a.Count > 0)
            {
                b.Push(a.Pop());
            }
        }

        public Problem3()
        {
            S1 = new Stack<T>();
            S2 = new Stack<T>();
        }
    }
}
