using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight
{
    class Problem2
    {
        /*
         * Problem 2 - Ordered Lists: 
         * A list is said to be in ascending order if all 10 values are listed in order from least to greatest. 
         * A list is said to be in descending order if all 10 values are listed in order from greatest to least. 
         * For this problem, there must be at least two different values in the list for it to be ordered. 
         * That is, a list with all duplicate values is not ordered
         * 
         * Input
         * The first line of input contains a single integer n, (1 ≤ n ≤ 1000), 
         * which is the number of test cases that follow. 
         * Each test case consists of a single line containing exactly ten integers. 
         * Each of the ten integers will always be separated by a single space.
         * 
         * Output
         * For each test case, 
         * generate one line of output in the exact format below indicating the list number, 
         * and whether the list is in ascending order, descending order, or not ordered. 
         * Do not forget the ending period.
         */

        public void OrderedList()
        {
            int[] A;
            int T;

            // Get the number of test cases
            Console.WriteLine("Enter the number of test cases to run");
            T = Convert.ToInt32(Console.ReadLine());

            // Output the Nthlargest of the i'th test case
            for (int i = 1; i <= T; i++)
            {
                // Get array from user
                Console.WriteLine("Enter the array of numbers");
                A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                // Output each test case
                Console.WriteLine($"List {i} {OrderedListUtil(A)}");
            }
        }

        public string OrderedListUtil(int[] A)
        {
            // Message to return
            string message = "";

            // Boolean flags
            bool ascending, descending;
            ascending = descending = false;

            for (int i = 1, j = i -1; i < A.Length; i++, j++)
            {
                // Check ascending
                if (A[j] < A[i] )
                {
                    ascending = true;
                }

                // Check descending
                else if (A[j] > A[i])
                {
                    descending = true;
                }

                // Check if not ordered don't keep looping
                if (ascending && descending)
                {
                    message = "is not ordered.";
                    return message;
                }
            }

            // Ascending order
            if (ascending)
            {
                message = "is in ascending order.";
            }
            // Descending order
            else if (descending)
            {
                message = "is in descending order.";
            }
            // Final corner case for not ordered
            else
            {
                message = "is not ordered.";
            }

            return message;
        }
    }
}
