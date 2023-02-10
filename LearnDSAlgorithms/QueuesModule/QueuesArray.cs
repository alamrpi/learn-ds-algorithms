namespace LearnDSAlgorithms.QueuesModule
{
    public class QueuesArray
    {
        int[] data;
        int front, rear, size;
        public QueuesArray(int arrayLenght)
        {
            data= new int[arrayLenght];
            front=0;
            rear=0;
            size=0;
        }

        public int Lenght() => size;

        public bool IsFull() => data.Length == size;

        public bool IsEmpty() => size == 0;

        public void Enqueue(int e)
        {
            if(IsFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            else
            {
                data[rear++] = e;
                size++;
            }
        }

        public int Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int e = data[front];
                front++;
                size--;
                return e;
            }
        }

        public void Display()
        {
            for (int i = front; i < rear; i++)
                Console.Write(data[i] + "--");
            Console.WriteLine();
        }
    }
}
