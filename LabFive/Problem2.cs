using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabFive
{
    class Problem2
    {
        /*
         * Problem 2 [30 points] Write a program that opens a text file (“input.txt”) and reads its contents. 
         * Then using a stack it reverses the lines of the file and saves them into another file (“output.txt”). 
         * Make sure to include running and space complexity for your code.
            Hint: use System.IO.File.WriteAllLines and System.IO.File.ReadAllLines,
         */

        // Time: O(n) Space: O(n)
        public void ReverseFile(string inputPath, string outputPath)
        {
            Stack<string> S = new Stack<string>();

            // Open the file to read from.
            string[] readText = File.ReadAllLines(inputPath);

            // Iterate over lines
            foreach (string s in readText)
            {
                S.Push(s);
            }

            // This text is added only once to the file.
            if (File.Exists(outputPath))
            {
                // Create a file to write to.
                File.WriteAllLines(outputPath, S, Encoding.UTF8);
            }
        }

    }
}
