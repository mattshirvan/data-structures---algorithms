using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab9
{
    class Problem3
    {
        /*
         * Problem 3 - Peaks and Valleys: 
         * In an array of integers, a "peak" is an element which is 
         * greater than or equal to the adjacent integers 
         * and a "valley" is an element which is less than or equal to the adjacent integers.
         * For example, in the array {5, 8, 6, 2, 3, 4, 6}, {8, 6} are peaks and {5, 2} are valleys.
         * Given an array of integers, sort the array into an alternating sequence of peaks and valleys.
         */

        public void ValleyPeaks(int[] A)
        {
            // Sort the array
            Array.Sort(A);

            for (int i = 1; i < A.Length; i += 2)
            {
                Swap(A, i - 1, i);
            }

            printA(A);
        }

        public void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
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
