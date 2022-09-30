using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcLab2
{
    class Problem3
    {
        /*
         * Problem 3 - Search: first larger than k EXTRA: What is the running time for your algorithm? Can you solve it in O(log n)?
         */
        
        public int LargerK(int[] list, int k, int low, int high)
        {
            // Calculate midpoint
            int mid = (low + high) / 2;

            // Base case
            if (low > high)
            {
                // Return an out of bounds index
                return -1;
            }
            // Binary Search 
            else
            {
                // K found
                if (k == list[mid])
                {
                    return mid;
                }
                // k is larger than elements
                else if (k > list[mid])
                {
                    return LargerK(list, k, mid + 1, high);
                }
                else
                {
                    // Found first largest do not keep recursing.
                    return list[mid];
                }
            }
        }
    }
}
