using LearnDSAlgorithms.LinkedListModule;

namespace LearnDSAlgorithms
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Circular Linked list
            var circular = new CircularLinkedList();
            circular.AddLast(5);
            circular.AddLast(2);
            circular.AddLast(9);
            circular.AddLast(8);
            circular.AddLast(6);
            circular.AddLast(7);
            circular.AddLast(4);

            //Traversing
            Console.WriteLine($"Size of list = {circular.Length()}");
            circular.Display();
            Console.WriteLine("=======================================");

            circular.AddFirst(10);
            circular.AddAnyPosition(15, 4);
            circular.RemoveFirst();
            Console.WriteLine($"Size of list = {circular.Length()}");
            circular.Display();
            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}