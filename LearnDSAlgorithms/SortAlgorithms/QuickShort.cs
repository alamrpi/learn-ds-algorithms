namespace LearnDSAlgorithms.SortAlgorithms
{
    public class QuickShort
    {
        public void Quicksort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(A, low, high);
                Quicksort(A, low, pi - 1);
                Quicksort(A, pi + 1, high);
            }
        }

        public int Partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot)
                    i++;
                while (i <= j && A[j] > pivot)
                    j--;
                if (i <= j)
                    Swap(A, i, j);

            } while (i < j);
            Swap(A, low, j);
            return j;
        }

        public void Swap(int[] A, int i, int j)
        {
            (A[j], A[i]) = (A[i], A[j]);
        }
    }
}
