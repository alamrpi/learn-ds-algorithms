namespace LearnDSAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Selection Sort Algorithm Implementations
    /// Time Complexity o(n*n)
    /// Space Complexity o(n)
    /// </summary>
    internal class SelectionSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                //compare next values of i
                int min_index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                        min_index = j;
                }

                //swap two values
                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;

            }
            return arr;
        }
    }
}
