using LearnDSAlgorithms.LinkedListModule;

namespace LearnDSAlgorithms.StackModule
{
    /// <summary>
    /// Stacks ADT using signle linked list
    /// </summary>
    public class StacksLinkedList
    {
        private SingleNode? top;
        private int size;
        public StacksLinkedList()
        {
            top = null;
            size = 0;
        }

        /// <summary>
        /// Check stack is empty.
        /// Time Complexity - o(1) - Primitive
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => size == 0;

        /// <summary>
        /// Get Stacks lenght.
        /// Time Complexity - o(1) - Primitive
        /// </summary>
        /// <returns></returns>
        public int Lenght() => size;

        /// <summary>
        /// stack essential method push.
        /// Time Complexity - o(1) - Primitive.
        /// </summary>
        /// <param name="element"></param>
        public void Push(int element)
        {
            var newest = new SingleNode(element, null);
            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }

            size++;
        }

        /// <summary>
        /// stack essential method Pop.
        /// Time Complexity - o(1) - Primitive.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            int e = top.element;
            top = top.next;
            size--;
            return e;
        }

        /// <summary>
        /// stack essential method Peek.
        /// Time Complexity - o(1) - Primitive.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.element;
        }

        /// <summary>
        /// Stack list display function
        /// Time Complexity o(n) - Linear
        /// </summary>
        public void Display()
        {
            SingleNode p = top;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}
