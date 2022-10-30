using LearnDSAlgorithms.LinkedListModule;
using LearnDSAlgorithms.StackModule;

namespace LearnDSAlgorithms
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Stacks Example
            var stack = new StacksArray(5);
            Console.WriteLine($"Is Stack Empty- {stack.IsEmpty()}");
            stack.Push(5);
            stack.Push(58);
            stack.Push(6);
            stack.Push(45);
            stack.Push(85);
            stack.Display();
            Console.WriteLine($"Pop - {stack.Pop()}");
            Console.WriteLine($"Peek - {stack.Peek()}");
            Console.ReadKey();
        }
    }
}