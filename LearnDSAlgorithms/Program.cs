using LearnDSAlgorithms.QueuesModule;
using LearnDSAlgorithms.SortAlgorithms;

namespace LearnDSAlgorithms
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            var selectionSort = new BubbleSort();
            var sortedList = selectionSort.Sort(new int[] { 5, 6,2,7,3, 5, 0, 45, 33, 67 });
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}