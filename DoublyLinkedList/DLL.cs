using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    /*
     * Worked alone on lab
     */
    class DoubleyLinkedList <T> where T : IComparable
    {
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; set; }

        public int Count { get; private set; }


        // Running time: O(1)
        public void DeleteFirst()
        {
            if (Head != null)
            {
                // Shift head over
                Head = Head.Next;

                // Get rid of reference 
                // Instead of relying on gargbage collector
                Head.Previous = null;

                // Reduce count
                Count--;
            }
            else
            {
                throw new Exception("you cannot delete the 'first' of an empty list");
            }
        }

        // Running time: O(1)
        public void DeleteLast() 
        {
            if (Tail == null) //IsEmpty()
            {
                throw new Exception("you cannot delete the 'last' of an empty list");
            }
            else if (Head.Next == Tail) //the list has one node
            {
                Head = Tail = null;

                // Reduce list count
                Count--;
            }
            else //the general case, we have at least two nodes
            {
                // Move pointer of tail to previous
                Tail = Tail.Previous;

                // Get rid of next reference
                Tail.Next = null;
                
                // Reduce list count
                Count--;
            }
        }

        // Running time: O(n)
        public void DeleteValue(T value) //delete the first occurrence of value from the list
        {
            if (Head == null)
            {
                throw new Exception("you cannot delete the head of an empty list");
            }
            else if (Head.Value.CompareTo(value) == 0) //delete head value
            {
                DeleteFirst();
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null && current.Next.Value.CompareTo(value) != 0)
                {
                    current = current.Next;//move current to the right
                }

                if (current.Next == null)
                {
                    throw new Exception("Value not in list");//value not found
                }
                else //value was found
                {
                    // Make next reference 
                    current.Next = current.Next.Next;

                    // Make sure next node has previous reference to current
                    current.Next.Previous = current;
                    Count--;
                }
            }
        }

        // Running time: O(n)
        public void DeleteValues(T value) //delete the all occurrences of value from the list
        {
            if (Head == null)
            {
                throw new Exception("you cannot delete the head of an empty list");
            }
            else if (Head.Value.CompareTo(value) == 0) //delete head value
            {
                DeleteFirst();
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    if (current.Next.Value.CompareTo(value) == 0)
                    {
                        current.Next = current.Next.Next;

                        // Make sure next node has previous reference to current
                        current.Next.Previous = current;
                        Count--;
                    }

                    //move current to the right
                    current = current.Next;
                }
            }
        }

        // Running time: O(n)
        public void DeleteNode(Node<T> node)
        {
            if (Head == null || node == null)
            {
                throw new Exception("you cannot delete the head of an empty list");
            }
            else if (node == Head) //delete head value
            {
                DeleteFirst();
            }
            else if (node == Tail) // Delete Tail
            {
                DeleteLast();
            }
            else
            {
                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }

                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }
            }
        }

        // Running time: O(1)
        public bool IsEmpty() 
        {
            return Head == null;
        }

        // Running time: O(n)
        public void PrintToConsole() 
        {
            if (IsEmpty())
                throw new Exception("Can't print an empty");
            else
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.Write($"{current.Value} -> ");//display the value
                    current = current.Next;
                }
                Console.WriteLine("Null");
                Console.WriteLine();
            }
        }

        // Running time: O(1)
        public void AddFirst(T ValueToAdd)
        {
            //1. create a new node
            Node<T> node = new Node<T>(ValueToAdd);
            //2. link in the new node
            node.Previous = null;
            node.Next = Head;

            if (IsEmpty())
            {
                Head = Tail = node;
            }

            //3. head is not null
            else if (Head != null)
            {
                Head.Previous = node;
            }

            //4. move the head
            Head = node;

            Count++;
        }

        // Running time: O(1)
        public void AddLast(T ValueToAdd)
        {
            if (IsEmpty()) //Head == null
            {
                AddFirst(ValueToAdd);
            }
            else
            {
                //1 create a new node
                Node<T> node = new Node<T>(ValueToAdd);

                Node<T> current = Tail;

                //2 link in the new node
                Tail = node;

                //3 make new node the tail
                Tail.Next = null;

                //4 make previous reference 
                Tail.Previous = current;

                Count++;
            }
        }

        // Running time: O(1)
        public void Append(T ValueToAdd)
        {
            AddLast(ValueToAdd);
        }

        public void Add(T ValueToAdd)
        {
            throw new NotImplementedException();
        }

        // Running time: O(n)
        public void AddAfter(Node<T> node, T value)
        {
            if (node == null)
            {
                throw new Exception("Can't insert after null");
            }

            Node<T> new_node = new Node<T>(value);

            new_node.Next = node.Next;

            node.Next = new_node;

            new_node.Previous = node;

            if (new_node.Next != null)
            {
                new_node.Next.Previous = new_node;
            }
            Count++;
        }

        // Running time: O(1)
        public void Clear() 
        {
            Head = Tail = null;
            Count = 0;
        }

        // Running time: O(n)
        public void Reverse()
        {
            if (IsEmpty())
            {
                throw new Exception("Can't reverse an empty list");
            }

            Node<T> current = Head;

            Node<T> temp = null; // Temporary node for swapping 

            while (current != null)
            {
                // Store reference to previous
                temp = current.Previous;

                // Switch directions of pointers
                current.Previous = current.Next;

                // replace reference in other direction
                current.Next = temp;

                // link node in
                current = current.Previous;
            }

            if (temp != null)
            {
                Head = temp.Previous;
            }
        }

        /* 
         * Object Constructors 
         */
        public DoubleyLinkedList()
        {
            Head = Tail = null;
            Count = 0;
        }

        public DoubleyLinkedList(Node<T> node)
        {
            Head = Tail = node;
            Count = 1;
        }

        public DoubleyLinkedList(Node<T> _Head, Node<T> _Tail)
        {
            Head = _Head;
            Tail = _Tail;
            Count = 2;
        }
    }
}
