using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab5
{

    /*
     Researches stack at O(n) with O(1) access
     */
    class Stack<T> where T : IComparable
    {
        //data
        SinglyLinkedList<T> values = new SinglyLinkedList<T>();
        public int Count { get; private set; }
        public T min { get; private set; }

        //methods

        //adds a new element to the top of the stack - O(1)
        public void Push(T newValue)
        {
            
            values.AddFirst(newValue);
            min = minimum(newValue); // Keep track of min value
            Count++;//increase the count
        }

        //removes the top element from a stack, and returns it - O(1)
        public T Pop()
        {
            if (!values.IsEmpty())
            {
                Count--;
                T ret = values.Head.Value;
                values.DeleteFirst();
                min = minimum(); // Keep track of min value
                return ret;
            }
            else
            {
                throw new Exception("Can't POP from an empty stack");
            }
        }

        //returns the top element from a stack without removing it - O(1)
        public T Peek()
        {
            if (!values.IsEmpty())
                return values.Head.Value;
            else
            {
                throw new Exception("Can't PEEK on an empty stack");
            }
        }

        public override string ToString()
        {
            return values.ToString();
        }

        // O(n) to research and set stack O(1) access
        public T minimum (T Value)
        {
            T ret = min; // set as current min

            if (values.IsEmpty())
            {
                throw new Exception("The list is empty");
            }
            else
            {
                Node<T> current = values.Head;
                while (current != null)
                {
                    // check if current min is 
                    if (ret.CompareTo(Value) > 0)
                    {
                        ret = Value;
                    }
                    current = current.Next; //moves the current to the right
                }
            }
            return ret;
        }

        // O(n) to research and set stack O(1) access
        public T minimum()
        {
            T ret = min; // set as current min

            if (values.IsEmpty())
            {
                throw new Exception("The list is empty");
            }
            else
            {
                Node<T> current = values.Head;
                while (current != null)
                {
                    // check if current min is 
                    if (ret.CompareTo(current.Value) > 0)
                    {
                        ret = current.Value;
                    }
                    current = current.Next; //moves the current to the right
                }
            }
            return ret;
        }

        public Stack()
        {
            
        }

        public Stack(T _min)
        {
            min = _min;
        }
    }
}
