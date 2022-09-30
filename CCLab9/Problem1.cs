using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab9
{
    class Problem1
    {
        /*
         * Problem 1 - Sorted Merge: 
         * You are given two sorted arrays, A and B, 
         * where A has a large enough buffer at the end to hold B. 
         * Write a method to merge B and A in sorted order. 
         * For this, create a new array, say C.
         */


        // O(n)
        public int[] Merge(int[] A, int[] B)
        {
            // New array for merger
            int[] C = new int[A.Length + B.Length];
            
            // Index for each half and new Array C
            int i = 0;
            int j = 0;
            int k = 0;

            // Merge until indices are = length
            while (i < A.Length && j < B.Length)
            {
                if (A[i] <= B[j])
                {
                    C[k++] = A[i++];
                }
                else
                {
                    C[k++] = B[j++];
                }
            }

            // Merge Left overs
            for (; i < A.Length; i++)
            {
                C[k++] = A[i];

            }

            for (; j < B.Length; j++)
            {
                C[k++] = B[j];

            }

            return C;
        }

        // Print the content of the array
        public void printA(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
