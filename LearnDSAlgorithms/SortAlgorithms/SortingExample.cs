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


    }
}
