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

        /// <summary>
        /// Add item in any porition of the linked list
        /// Time Complexity - o(n) - Linear
        /// </summary>
        /// <param name="element"></param>
        /// <param name="position"></param>
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
        /// Remove first item in doubly linked list
        /// Time Complexoty o(1) - Primitive
        /// </summary>
        /// <returns></returns>
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }

            var e = head.element;

            head = head.next;
            head.prev = null;
            size--;

            if (IsEmpty())
            {
                tail = null;
            }
            return e;
        }

        /// <summary>
        /// Remove Last item in doubly linked list
        /// Time Complexity - o(1) - Primitive
        /// </summary>
        /// <returns></returns>
        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }

            var e = tail.element;

            tail = tail.prev;
            tail.next = null;
            size--;

            return e;
        }

        public int RemoveAnyPosition(int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return -1;
            }

            var point = head;
            int i = 1;
            while (i < position - 1)
            {
                point = point.next;
                i++;
            }
            int e = point.next.element;
            point.next = point.next.next;
            point.next.prev = point;
            size--;
            return e;
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
