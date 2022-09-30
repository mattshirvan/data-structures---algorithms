using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab4
{
    class Problem1
    {
        /*
         * Remove duplicates from a singly linked list
         */

        /*
         * 
         * public Node<int> MergeSort(Node<T> node)
         {
            // Base Case
            if (node == null or node.next == null)
            {
                return node;
            }

            // get the middle of the list
            Node<int> middle = Middle(node);
            Node<int> neighbor = middle.next;
 
            // set the next of middle node to null
            middle.next = null;
 
            // Apply mergeSort on left list
            left = MergeSort(h);
         
            // Apply mergeSort on right list
            right = mergeSort(nexttomiddle);
 
            //  Merge the left and right lists
            sortedlist = sortedMerge(left, right);
            return sortedlist;
        }
    # Utility function to get the middle
    # of the linked list
    def getMiddle(self, head):
        if (head == None):
            return head
 
        slow = head
        fast = head
 
        while (fast.next != None and
               fast.next.next != None):
            slow = slow.next
            fast = fast.next.next
             
        return slow
         */

        SinglyLinkedList<int> list = new SinglyLinkedList<int>();

        public Node<int> MergeSort(Node<int> head)
        {

            return null;
        }

        public Node<int> Merge(Node<int> one, Node<int> two)
        {
            return null;
        }

        public Node<int> Middle(Node<int> head)
        {
            return null;
        }

        public Problem1()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(5);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(2);
            list.AddLast(1);
            list.AddLast(4);
            list.AddLast(3);
            list.AddLast(5);
            list.PrintToConsole();
        }
    }
}
