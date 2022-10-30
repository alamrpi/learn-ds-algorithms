namespace LearnDSAlgorithms.StackModule
{
    /// <summary>
    /// Stack abastract Data type
    /// </summary>
    public class StacksArray
    {
        private int top;
        private int[] data;
        public StacksArray(int maximumLenght)
        {
            data = new int[maximumLenght];
            top = 0;
        }

        public int Lenght() => top;

        public bool IsEmpty() => top == 0;

        public bool IsFull() => top == data.Length;

        public void Push(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack if Full/Overflow");
                return;
            }
            else
            {
                data[top] = element;
                top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty/UnderFlow");
                return -1;
            }

            int e = data[--top];
            return e;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return data[top - 1];
        }

        public void Display()
        {
            for (int i = 0; i < top; i++)
                Console.Write(data[i] + "--");
            Console.WriteLine();
        }
    }
}
