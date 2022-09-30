namespace LearnDSAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursion Example Here
            var recursion = new Recursion();
            //recursion.TailRecursion(4);
            //recursion.HeadRecursion(4);
            recursion.TreeRecursion(3);

            Console.ReadKey();
        }
    }
}