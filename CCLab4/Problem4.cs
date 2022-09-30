using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab4
{
    class Problem4
    {
        /*
         * Problem 4 - Google interview question 
         * You have 123 which is described in the linked list like 1->2->3. 
         * How do you increase the number by one and print.
         */

        public void OnePrint(SinglyLinkedList<int> list)
        {
            Node<int> current = list.Head;

            while(current != null)
            {
                Console.WriteLine(current.Value += 1);
                current = current.Next;
            }
        }

        public SinglyLinkedList<int> TestOP1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            return list;
        }

        public SinglyLinkedList<int> TestOP2()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(44);
            list.AddLast(82);
            list.AddLast(53);
            list.AddLast(11);
            list.AddLast(22);
            list.AddLast(123);

            return list;
        }

        public SinglyLinkedList<int> TestOP3()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddLast(0);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);
            list.AddLast(9);

            return list;
        }
    }
}
