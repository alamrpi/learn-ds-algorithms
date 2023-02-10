namespace LearnDSAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Time Complexity: O(N^2) 
    /// Auxiliary Space: O(1)
    /// </summary>
    internal class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
