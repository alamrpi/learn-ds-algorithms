namespace LearnDSAlgorithms.LinkedListModule
{
    public class DoublyLinkList : LinkedList<DoublyNode>
    {
        /// <summary>
        /// Add item in last position of doubly libnked list.
        /// Time Complexity o(1) - Primitive
        /// </summary>
        /// <param name="e"></param>
        public void AddLast(int e)
        {
            var newest = new DoublyNode(e, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }

            size++;
        }

        /// <summary>
        /// Add item in first position of doubly libnked list.
        /// Time Complexity o(1) - Primitive
        /// </summary>
        /// <param name="element"></param>
        public void AddFirst(int element)
        {
            var newest = new DoublyNode(element, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size++;
        }

        public void AddAnyPosition(int element, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return;
            }

            var newest = new DoublyNode(element, null, null);
            var p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            newest.next = p;
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size++;
        }

        /// <summary>
        /// Traversing Of doubly linked List.
        /// Time Complexity o(n) - Linear
        /// </summary>
        public void Display()
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
