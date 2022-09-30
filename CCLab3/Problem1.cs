using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab3
{
    class Problem1
    {
        /*
         * Problem 1 - Microsoft interview question 
         * sorted array with all elements appear twice except one, 
         * find that element (the best solution should be O(logn))
         */

        // Tabulate values 
        Dictionary<int, int> table = new Dictionary<int, int>();

        // O(n)
        public int AppearTwice(int[] numbers)
        {
            // Iterate array linearly
            for (int i = 0; i < numbers.Length; i++)
            {
                // Tabulate results
                try
                {
                    table[numbers[i]] += 1;
                }
                catch (KeyNotFoundException)
                {
                    table.Add(numbers[i], 1);
                }
            }

            // Return first instance of count of 1
            return table.FirstOrDefault(x => x.Value == 1).Key;
        }

        // O(log n) didn't have time to optimize
        public int AppearsTwice(int[] numbers, int low, int high)
        {
            // Midpoint
            int mid = (low + high) / 2;

            // Base Case
            if (low < high)
            {
                return -1;
            }

            // Tabulate results
            try
            {
                table[numbers[mid]] += 1;
            }
            catch (KeyNotFoundException)
            {
                table.Add(numbers[mid], 1);
            }

            // FIX ME: add recursive calls

            // Return first instance of count of 1
            return table.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}
