using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Node<T> where T : IComparable
    {
        public T Value { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public bool Visited { get; set; }

        public Node()
        {
                
        }

        public Node(T _Value)
        {
            Value = _Value;
        }
    }
}
