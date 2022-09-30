using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Sort<T> where T : IComparable
    {
        public void QuickSort(T[] A, int low, int high)
        {
            if (low < high)
            {
                int mid = Partition(A, low, high);
                QuickSort(A, low, mid);
                QuickSort(A, mid + 1, high);
            }
        }

        public int Partition(T[] A, int low, int high)
        {
            // Value in right partition
            T x = A[high];

            // Left partition
            int i = low - 1;

            // Sort 
            for (int j = low; j < high; j++)
            {
                // Compare against pivot value
                if (A[j].CompareTo(x) <= 0)
                {
                    // Increment i
                    i++;

                    // Swap A[i] with A[j]
                    Swap(A, i, j);

                }
            }

            // Swap A[i + 1] with A[high]
            Swap(A, i + 1, high);

            return i;
        }

        public void Swap(T[] A, int i, int j)
        {
            T temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public void Print(T[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine();
        }
    }
}
