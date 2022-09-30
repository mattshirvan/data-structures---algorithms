using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight
{
    class Problem3
    {
        int[][] A { get; set; }
        int[] row_col { get; set; }
        int[] totals { get; set; }
        int T { get; set; }

        // O(n^2)
        public void DiverseMatrix()
        {
            // Get the number of test cases
            Console.WriteLine("Enter the number of test cases to run");
            T = Convert.ToInt32(Console.ReadLine());

            // Output the Nthlargest of the i'th test case
            for (int i = 1; i <= T; i++)
            {
                // Get rows and columns of matrix from user
                Console.WriteLine("Enter the number of rows and columns");
                row_col = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                // New 2d matrix with empty rows
                A = new int[row_col[0]][];

                // Get Matrix from user
                for (int j = 0; j < row_col[0]; j++)
                {
                    Console.WriteLine($"Enter the array of numbers for row {j+1}");
                    A[j] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                }    

                // Output each test case
                Console.WriteLine($"{DiverseMatrixUtil()}");
            }
        }

        public string DiverseMatrixUtil()
        {
            // Unique values only
            HashSet<int> set = new HashSet<int>();
            
            // Add values to hashset
            for (int i = 0; i < row_col[0]; i++)
            {
                // Check if each row total is unique
                if (!set.Add(A[i].Sum()))
                {
                    return "no";
                }

            }
            // each value row total was unique
            return "yes";
        }
    }
}
