namespace LearnDSAlgorithms.LinkedListModule
{
    public class LinkedList
    {
        protected Node? head;
        protected Node? tail;
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
