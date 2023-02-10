namespace LearnDSAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Bubble Sort algorithm implemented
    /// Time Complexity o(n*n)
    /// Space Complexity o(n)
    /// </summary>
    internal class BubbleSort
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                //compare two values between j index and (j+1) index
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
