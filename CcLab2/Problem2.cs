using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcLab2
{
    class Problem2
    {
        /*
         * Problem 2 - Reverse word order 
         * Reverse words in a sentence, eg. "Hello there children" -> "children there Hello"
            EXTRA: solve it without using additional space
         */

        public String WordSwap(String text)
        {
            // Create new string instead of data structure
            String new_s = "";

            // Create a temp string instead of data structure
            String temp = "";

            // Loop through string and add words to new string
            for (int i = 0; i < text.Length; i++)
            {
                // Character is not whitespace
                if (!Char.IsWhiteSpace(text[i]))
                {
                    // Create word from characters
                    temp += text[i];
                }
                else
                {
                    // String is not empty
                    if (new_s.Length > 0)
                    {
                        // Reverse words
                        new_s = temp + " " + new_s;
                    }
                    else
                    {
                        // Add word to empty string
                        new_s = temp;
                    }
                    // Reset temp string
                    temp = "";
                }
            }

            // Add last word
            new_s = temp + " " + new_s;

            return new_s;
        }
    }
}
