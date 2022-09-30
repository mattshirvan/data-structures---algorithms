using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree
{
    class Heap<T> where T : IComparable
    {
        List<T> A { get; set; }
        int HeapSize { get; set; }
        
        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public int Left(int i)
        {
            return 2*i + 1;
        }

        public int Right(int i)
        {
            return 2 * i + 2;
        }

        public void MaxHeapify(List<T> A, int i)
        {
            int l = Left(i);
            int r = Right(i);

            if (l < A.Count && A[l].CompareTo(A[i]) > 0)
            {

            }

        }
    }
}
