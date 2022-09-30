using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab4
{
    class Problem2
    {
        /*
         * Problem 2 - Palindrome: Implement a function to check if a given singly linked list is a palindrome. 
         */

        SinglyLinkedList<String> list { get; set; }

        // O(n)
        public bool PalindromeSLL(SinglyLinkedList<String> list)
        {
            // Current Head
            Node<String> current = list.Head;

            // Strings to store chars
            string s1 = "";
            string s2 = "";

            // Traverse list
            while (current != null)
            {
                // Add letters to first string
                s1 += current.Value;

                // Add letters in reverse to the second string
                s2 = current.Value + s2;

                // Move to next node
                current = current.Next;
            }

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            return s1 == s2;
        }
        
        public SinglyLinkedList<String> TestPalind1()
        {
            SinglyLinkedList<String> list = new SinglyLinkedList<String>();

            list.AddLast("t");
            list.AddLast("a");
            list.AddLast("c");
            list.AddLast("o");
            list.AddLast("c");
            list.AddLast("a");
            list.AddLast("t");

            return list;
        }

        public SinglyLinkedList<String> TestPalind2()
        {
            SinglyLinkedList<String> list = new SinglyLinkedList<String>();

            list.AddLast("b");
            list.AddLast("o");
            list.AddLast("b");
            list.AddLast("o");
            list.AddLast("p");
            list.AddLast("o");
            list.AddLast("p");

            return list;
        }

        public SinglyLinkedList<String> TestPalind3()
        {
            SinglyLinkedList<String> list = new SinglyLinkedList<String>();

            list.AddLast("I");
            list.AddLast("r");
            list.AddLast("a");
            list.AddLast("n");

            return list;
        }
    }
}
