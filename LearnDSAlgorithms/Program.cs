using LearnDSAlgorithms.RecursionModule;

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

            var exSum = new ExSum();
            Console.WriteLine(exSum.SumOfNUsingFormula(5));
            Console.WriteLine(exSum.SumOfNUsingItteration(5));
            Console.WriteLine(exSum.SumOfNUsingRecursion(5));

            Console.ReadKey();
        }
    }
}