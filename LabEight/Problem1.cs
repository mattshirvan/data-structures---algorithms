using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight
{
    class Problem1
    {
        /*
         * Problem 1 - Nth Largest Value: 
         * Write a C# program that prints the Nth largest value in a fixed sized array of integers. 
         * To make things simple, N will be 3 and the array will always have 10 decimal integer values.
         */

        /*
         * Input
         * The first line of input contains a single integer n, (1 ≤ n ≤ 1000), 
         * which is the number of test cases that follow. 
         * Each test case consists of a single line containing:
         * test case number, followed by a space.
         * Followed by ten decimal integers whose values are between 1 and 1000 inclusive. 
         * Each of the ten integers will always be separated by a single space.
         * 
         * Output
         * For each test case, generate one line of output with the following values: 
         * the test case number, a space, and the 3rd largest value of the corresponding 10 integers.
         */

        // O(n lg n) using merge sort
        public void NthLargest()
        {
            int[] A;
            int N, T;

            // Get the number of test cases
            Console.WriteLine("Enter the number of test cases to run");
            T = Convert.ToInt32(Console.ReadLine());

            // Output the Nthlargest of the i'th test case
            for (int i = 1; i <= T; i++)
            {
                // Get array from user
                Console.WriteLine("Enter the array of numbers");
                A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                // Get N from user to find Nth largest
                Console.WriteLine("Enter N for the Nth largest value in the array");
                N = Convert.ToInt32(Console.ReadLine());

                // Sort the array 
                MergeSort(A, 0, A.Length - 1);

                // Output each test case
                Console.WriteLine($"{i} {A[A.Length - N]}");
            }
        }

        // Nthlargest util to get array and variables
        public void NthLargestUtil()
        {

        }

        // MergeSort: O(n lg n) = O(lg n) to Sort O(n) to merge
        public void MergeSort(int[] A, int low, int high)
        {
            // Create partition
            int mid = (low + high) / 2;

            // base case
            if (low < high)
            {
                // Sort the left half
                MergeSort(A, low, mid);

                // Sort the right half
                MergeSort(A, mid + 1, high);

                // Merge!
                Merge(A, low, mid, high);
            }
        }

        public void Merge(int[] A, int low, int mid, int high)
        {
            // Partition indices to left and right 
            int left = mid - low + 1;
            int right = high - mid;

            // Left and right partitions of A
            int[] L = new int[left + 1], R = new int[right + 1];

            // Declare indexes for iterations
            int i, j, k;

            // load the L sub_array
            for (i = 0; i < left; i++)
            {

                // Insert into left partition
                L[i] = A[low + i];


            }

            // load the R sub_array
            for (j = 0; j < right; j++)
            {

                // Insert into right partition
                R[j] = A[mid + 1 + j];
            }

            // set the sentinel values
            L[left] = Int32.MaxValue;
            R[right] = Int32.MaxValue;

            // reset values
            i = 0;
            j = 0;

            // merge L and R sub_arrays
            for (k = low; k < high + 1; k++)
            {

                // Merge left half
                if (L[i] <= R[j])
                {

                    // Merge L into main array A
                    A[k] = L[i++];

                }

                // Otherwise merge right half
                else
                {

                    // Merge R into main array A
                    A[k] = R[j++];
                }
            }
        }

        // Print the content of the array
        public void printA(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
