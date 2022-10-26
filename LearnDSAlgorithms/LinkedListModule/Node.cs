namespace LearnDSAlgorithms.LinkedListModule
{
    public class Node
    {
        public int element;
        public Node? next;

        public Node(int element, Node? node)
        {
            this.element = element;
            next = node;
        }
    }
}
