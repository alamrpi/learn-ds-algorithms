namespace LearnDSAlgorithms.SortAlgorithms
{
    public class SortingExample
    {
        /// <summary>
        /// Display array value in console
        /// </summary>
        /// <param name="data">array of data which is display.</param>
        public void DisplayArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write($"{data[i]} ");

            Console.WriteLine(" ");
        }

        /// <summary>
        /// Selection sort algorithoms example
        /// </summary>
        /// <param name="data">array of data</param>
        /// <returns>sorted array</returns>
        public int[] SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[position])
                        position = j;
                }

                int temp = data[i];
                data[i] = data[position];
                data[position] = temp;
            }
            return data;
        }

        /// <summary>
        /// Insertion Sort algorithms example
        /// </summary>
        /// <param name="data">Unsorted data</param>
        /// <returns>sorted data</returns>
        public int[] InsertionSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int compareValue = data[i];
                int position = i;

                while(position > 0 && data[position-1] > compareValue)
                {
                    data[position] = data[position - 1];
                    position--;
                }

                data[position] = compareValue;
            }
            return data;
        }

        /// <summary>
        /// Bubble Sort Algorithms example
        /// </summary>
        /// <param name="data">unsorted array</param>
        /// <returns>sorted array</returns>
        public int[] BubbleSort(int[] data)
        {
            for (int i = data.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int tempData = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tempData;
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Shell Sort Algorithms example
        /// </summary>
        /// <param name="data">unsorted array</param>
        /// <returns>sorted array</returns>
        public int[] ShellSort(int[] data)
        {
            //Time Coplexity O(nlog(n))
            int n = data.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = data[i];
                    int j = i - gap;
                    while (j >= 0 && data[j] > temp)
                    {
                        data[j + gap] = data[j];
                        j -= gap;
                    }
                    data[j + gap] = temp;
                    i++;
                }
                gap /= 2;
            }
            return data;
        }

    }
}
