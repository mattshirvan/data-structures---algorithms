using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoBigO
{
    class ArraysAndStrings
    {
        public bool isUnique(String sentence)
        {
            // Lowercase all letters
            sentence = sentence.ToLower();

            // Length of the string
            int n = sentence.Length;

            String temp = "";

            for (int i = 0; i < n; i++)
            {
                foreach (char c in temp)
                {
                    if (sentence[i] == c)
                    {
                        return false;
                    }
                }

                temp += sentence[i];
            }
            return true;
        }

    }
}
