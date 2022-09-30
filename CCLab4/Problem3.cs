using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab4
{
    class Problem3
    {
        /*
         * Problem 3 - Intersection of Two Linked Lists
         * Given the heads of two singly linked-lists A and B, 
         * return the node at which the two lists intersect. 
         * If the two linked lists have no intersection at all, return null.

            Two linked lists begin to intersect at node c1:
            A:     a1->a2->
                           c1->c2->c3->null
            B: b1->b2->b3->
         */
        public Node<int> Instersection(Node<int> a, Node<int> b)
        {
            // Empty list
            if (a == null || b == null)
            {
                return null;
            }

            // Insertects at head
            else if (a.Value == b.Value)
            {
                return a;
            }

            // Pointers for traversing
            Node<int> p1 = a;
            Node<int> p2 = b;

            // Traverse until at the last value of both lists
            while (p1.Next != null || p2.Next != null)
            {
                // Intersection when values are same
                if (p1.Value == p2.Value)
                {
                    return p1;
                }
                
                // Only advance pointers up to end of list 
                if (p1.Next != null)
                {
                    p1 = p1.Next;
                }
                if (p2.Next != null)
                {
                    p2 = p2.Next;
                }
            }

            // No Intersection
            return null;
        }

        public SinglyLinkedList<int> TestIntersection1()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            return list;
        }

        public SinglyLinkedList<int> TestIntersection2()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(44);
            list.AddLast(82);
            list.AddLast(53);
            list.AddLast(11);
            list.AddLast(22);
            list.AddLast(123);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            return list;
        }

        public SinglyLinkedList<int> TestIntersection3()
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
        public SinglyLinkedList<int> TestIntersection4()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);
            list.AddLast(9);

            return list;
        }
    }
}

