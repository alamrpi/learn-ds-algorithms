namespace LearnDSAlgorithms.LinkedListModule
{
    public class DoublyNode : Node
    {
        public DoublyNode? next;
        public DoublyNode? prev;
        public DoublyNode(int element, DoublyNode? next, DoublyNode? prev) : base(element)
        {
            this.next = next;
            this.prev = prev;
        }
    }
}
