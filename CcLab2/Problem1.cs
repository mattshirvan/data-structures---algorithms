using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcLab2
{
    class Problem1
    {
        /*
         * Problem 1 - Palindrome Permutation (1.4)
         * Given a string, write a function to check if it is a permutation of a palindrome. 
         * A palindrome is a word or phrase that is the same forwards and backwards. 
         * A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
         * EXAMPLE
            Input: Tact Coa
            Output: True    (explanation - not part of the output ... permutations: "taco cat". "atco cta". etc.)
         */

        // Use to store and reduce runtime O(n) 
        Hashtable ht { get; set; }

        public Problem1()
        {
            this.ht = new Hashtable();
        }

        public String Reversal(String s)
        {
            /*
             * Returns a copy of given string s reversed.
             */

            // New string to return
            String next_s = "";
         
            // Loop through string
            for (int i = s.Length-1; i > -1; i--)
            {
                // Add ith position to new string 
                next_s += s[i];
            }

            return next_s;
        }

        public void Permute(String s, int start, int end)
        {
            /*
             * Returns a permutation of string s
             */

            // Base Case
            if (start == end)
            {
                Console.WriteLine(s);
            }

            // Recursively permute string
            else
            {
                // Loop through string to get characters
                for (int i = start; i <= end; i++)
                {
                    // Add to hashtable to reduce computation
                    try
                    {
                        ht.Add(i, s);
                    }
                    catch
                    {
                        // Check if permutation is palindrome
                        if ((string)this.ht[i] == this.Reversal(s))
                        {
                            Console.WriteLine(true);
                            Environment.Exit(0);
                        }
                    }

                    // Swap positions
                    s = Swap(s, start, i);

                    // Permute string
                    Permute(s, start + 1, end);

                    // Swap again.
                    s = Swap(s, start, i);
                }
            }
        }

        public String Swap(String s, int start, int end)
        {
            /*
             * Swaps position of characters for permutation
             */

            // Character Array
            char[] charArray = s.ToCharArray();

            // Temp storage of current character
            char temp = charArray[start];

            // Swap characters at position
            charArray[start] = charArray[end];
            charArray[end] = temp;

            // Convert back to string
            string st = new string(charArray);

            return st;
        }

        public void PalindromePermutation(String text)
        {
            /*
             * Outputs a true/false if the string is/isn't a permutation of a palindrome.
             */

            // User String
            int n = text.Length;

            // O(n) to create and copy string text in reverse 
            Permute(text, 0, n-1);
        }

    }
}
