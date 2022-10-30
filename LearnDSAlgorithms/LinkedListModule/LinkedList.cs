namespace LearnDSAlgorithms.LinkedListModule
{
    public class LinkedList<T> where T : class
    {
        protected T? head;
        protected T? tail;
        protected int size;

        //Constructor
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length() => size;

        public bool IsEmpty() => size == 0;

    }
}
