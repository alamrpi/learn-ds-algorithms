using LearnDSAlgorithms.LinkedListModule;

namespace LearnDSAlgorithms
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Circular Linked list
            var doubly = new DoublyLinkList();
            doubly.AddLast(5);
            doubly.AddLast(2);
            doubly.AddLast(9);
            doubly.AddLast(8);
            doubly.AddLast(6);
            doubly.AddLast(7);
            doubly.AddLast(4);

            //Traversing
            Console.WriteLine($"Size of list = {doubly.Length()}");
            doubly.Display();
            Console.WriteLine("=======================================");

            //circular.AddFirst(10);
            //circular.AddAnyPosition(15, 4);
            //circular.RemoveFirst();
            //Console.WriteLine($"Size of list = {circular.Length()}");
            //circular.Display();
            //Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}