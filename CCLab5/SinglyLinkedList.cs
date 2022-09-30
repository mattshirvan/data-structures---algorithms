using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab5
{
    class SinglyLinkedList<T> where T : IComparable
    {
        //data?  characteristics
        public Node<T> Head { get; private set; }

        public int Count { get; private set; }

        //method? behavior/actions/operations

        public void DeleteFirst() //running time O(1)
        {
            if (Head != null)
            {
                Head = Head.Next;
                Count--;
            }
            else
                throw new Exception("you cannot delete the 'first' of an empty list");

        }

        public void DeleteLast() //running time: O(n)
        {
            if (Head == null) //IsEmpty()
            {
                throw new Exception("you cannot delete the 'last' of an empty list");
            }
            else if (Head.Next == null) //the list has one node
            {
                Head = null;
                Count--;
            }
            else //the general case, we have at least two nodes
            {
                //1. traverse the list, to next to the last node
                Node<T> finger = Head;
                while (finger.Next.Next != null)
                {
                    finger = finger.Next; //move finger to the right
                }

                //2. link the last node out
                finger.Next = null;
                Count--;
            }
        }

        public void DeleteValue(T value) //delete the first occurrence of value from the list
        {
            if (Head == null)
                throw new Exception("you cannot delete the head of an empty list");
            else if (Head.Value.CompareTo(value) == 0) //delete head value
            {
                DeleteFirst();
            }
            else
            {
                Node<T> finger = Head;
                while (finger.Next != null && finger.Next.Value.CompareTo(value) != 0)
                    finger = finger.Next;//move finger to the right

                if (finger.Next == null)
                    Console.WriteLine("Value was not found");//value not found
                else //value was found
                {
                    finger.Next = finger.Next.Next;
                    Count--;
                }
            }
        }

        public void DeleteValues(T value) //delete the all occurrences of value from the list
        {
            if (Head == null)
                throw new Exception("you cannot delete the head of an empty list");
            else if (Head.Value.CompareTo(value) == 0) //delete head value
            {
                DeleteFirst();
            }
            else
            {
                Node<T> finger = Head;
                while (finger.Next != null)
                {
                    if (finger.Next.Value.CompareTo(value) != 0)
                    {
                        finger.Next = finger.Next.Next;
                        Count--;
                    }

                    //move finger to the right
                    finger = finger.Next;
                }
            }
            PrintToConsole();
        }

        public void DeleteIndex(int index)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty() //traversal, running time O(1)
        {
            return Head == null;
        }


        public void PrintToConsole() //traversal, running time: O(n)
        {
            if (IsEmpty())
                Console.WriteLine("The list is empty");
            else
            {
                Node<T> finger = Head;
                while (finger != null)
                {
                    Console.Write($"{finger.Value} -> ");//display the value
                    finger = finger.Next; //moves the finger to the right
                }
                Console.WriteLine("Null");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void AddFirst(T ValueToAdd)//running time O(1)
        {
            //1. create a new node
            Node<T> newNode = new Node<T>(ValueToAdd);

            //2. link in the new node
            newNode.Next = Head;

            //3. move the head
            Head = newNode;

            Count++;
        }

        public void AddLast(T ValueToAdd)
        {
            if (IsEmpty()) //Head == null
            {
                AddFirst(ValueToAdd);
            }
            else
            {
                //1 create a new node
                Node<T> newNode = new Node<T>(ValueToAdd);

                //2 move to/find the last node
                Node<T> finger = Head;
                while (finger.Next != null) //if there is a next node
                {
                    finger = finger.Next;//move finger to the right
                }

                //3 link in the new node
                finger.Next = newNode;

                Count++;
            }
        }

        public void Append(T ValueToAdd)
        {
            AddLast(ValueToAdd);
        }

        public void Add(T ValueToAdd)//if the list is sorted, this will maintain the sorting
        {
            throw new NotImplementedException();
        }


        public void Clear() //deletes all values from the list  O(1)
        {
            Head = null;
            Count = 0;
        }

        public void Corrupt()
        {
            /*
             * Create Circular linked list
             */


            // Current node during traversal
            Node<T> current = Head;

            // Traverse linked list
            while (current != null)
            {
                current = current.Next;

                if (current.Next == null)
                {
                    current.Next = Head.Next.Next;
                    Console.WriteLine("Corrupted List");
                    return;
                }
            }

        }


        //ctors
        public SinglyLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public SinglyLinkedList(Node<T> _Head)
        {
            Head = _Head;
            Count = 1;
        }
    }
}
