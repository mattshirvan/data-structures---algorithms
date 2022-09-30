using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoBigO
{
    class Sorter
    {
        public void merge(int[] A, int low, int mid, int high) 
        {
            int i, j;
            int n1 = mid - low + 1;
            int n2 = high - mid;

            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (i = 0; i < n1; i++)
            {
                L[i] = A[low + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = A[mid + 1 + j];
            }

            L[n1] = 22222222;
            R[n2] = 22222222;

            i = 0;
            j = 0;

            for (int k = low; k < high+1; k++)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i++];
                }
                else
                {
                    A[k] = R[j++];
                }
            }
        }

        public void mergeSort(int[] A, int low, int high)
        {
            int mid;

            if (low < high)
            {
                mid = (low + high) / 2;
                mergeSort(A, low, mid);
                mergeSort(A, mid + 1, high);
                merge(A, low, mid, high);
            }
        }

        public void InsertionSort(int[] A)
        {
            int i, j;
        }
    }
}
