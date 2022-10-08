using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Merge sort also called conquer and divide.
    /// </summary>
    public class MergeSortExample
    {
        /// <summary>
        /// Divide smallest subsite of an array
        /// </summary>
        /// <param name="A">array of data</param>
        /// <param name="left">left index of an array</param>
        /// <param name="right">right index of an array</param>
        public void MergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(A, left, mid);
                MergeSort(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }

        /// <summary>
        /// Merged and sort subset (Conquer)
        /// </summary>
        /// <param name="A">array of data</param>
        /// <param name="left">left index of array</param>
        /// <param name="mid">mid index of array </param>
        /// <param name="right">right index of array</param>
        private void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j++;
                k++;
            }
            for (int x = left; x < right + 1; x++)
                A[x] = B[x];
        }
    }
}
