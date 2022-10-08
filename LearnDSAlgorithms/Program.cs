using LearnDSAlgorithms.SortAlgorithms;

namespace LearnDSAlgorithms
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Recursion Example Here
            //var recursion = new Recursion();
            //recursion.TailRecursion(4);
            //recursion.HeadRecursion(4);
            //recursion.TreeRecursion(3);

            //Sum Of n natural number
            //var exSum = new ExSum();
            //Console.WriteLine(exSum.SumOfNUsingFormula(5));
            //Console.WriteLine(exSum.SumOfNUsingItteration(5));
            //Console.WriteLine(exSum.SumOfNUsingRecursion(5));

            //Factorial of a number
            //var factorial = new Factorial();
            //Console.WriteLine(factorial.FactorialRecursion(3));
            //Console.WriteLine(factorial.FactorialItterative(3));

            //Searching Algorithms example
            //var search = new Search();
            //Console.WriteLine(search.LinearSearch(new int[] { 5, 6, 7, 89, 88, 99 }, 99));
            //Console.WriteLine(search.BinearySearchItterative(new int[] { 5, 6, 7, 87, 88, 99 }, 99));


            //Sorting Example
            var sortingExample = new SortingExample();
            var data = new int[] { 5, 2, 8, 89, 78, 65, 50, 85 };
            Console.WriteLine("------------Unsorted array------------");
            sortingExample.DisplayArray(data);


            //var sortedData = sortingExample.BubbleSort(data);
            var merg = new MergeSortExample();
            merg.MergeSort(data, 0, data.Length - 1);
            Console.WriteLine("------------Sorted array------------");
            sortingExample.DisplayArray(data);
            Console.ReadKey();
        }
    }
}