namespace LearnDSAlgorithms.LinkedListModule
{
    public class SingleNode : Node
    {
        public SingleNode? next;

        public SingleNode(int element, SingleNode? next) : base(element)
        {
            this.next = next;
        }
    }
}
