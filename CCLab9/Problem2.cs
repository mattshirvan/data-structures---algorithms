using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab9
{
    class Problem2
    {
        /*
         * Problem 2 - Sparse Search: 
         * Given a sorted array of strings that is interspersed with empty strings, 
         * write a C# method to find the location of a given string.
         */

        // O(n)
        public int SparseSearch(string word, string[] sparse)
        {
            for (int i = 0; i < sparse.Length; i++)
            {
                if (sparse[i] == word)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
