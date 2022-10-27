namespace LearnDSAlgorithms.LinkedListModule
{
    public class CircularLinkedList : LinkedList
    {
        /// <summary>
        /// //add item in last position.
        /// Time Complexity- O(1) Primitive
        /// </summary>
        /// <param name="e"></param>
        public void AddLast(int e)
        {
            var newest = new Node(e, null);
            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }

            tail = newest;
            size++;
        }

        /// <summary>
        /// add item in first position of circular linked list.
        /// Time Complexity - O(1) - Primitive
        /// </summary>
        /// <param name="e"></param>
        public void AddFirst(int e)
        {
            var newNode = new Node(e, null);
            if (IsEmpty())
            {
                newNode.next = newNode;
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        /// <summary>
        /// Add item in a fixed position of the circular linked list.
        /// Time complexity - O(n) - Linear
        /// </summary>
        /// <param name="e"></param>
        public void AddAnyPosition(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return;
            }

            var newest = new Node(e, null);
            var p = head;
            int i = 1;
            while (i < (position - 1))
            {
                p = p.next;
                i++;
            }
            newest.next = p.next;
            p.next = newest;
            size++;
        }
        
        /// <summary>
        /// Remove first element in the linked list.
        /// Time complexity - O(1) - Primitive 
        /// </summary>
        /// <returns></returns>
        public int RemoveFirst()
        {
            if(IsEmpty())
            {
                Console.WriteLine("The linked list is empty");
                return -1;
            }

            int e = head.element;
            tail.next = head.next;
            head = head.next;
            size--;

            if (IsEmpty())
            {
                head = null;
                tail = null;
            }

            return e;
        }

        /// <summary>
        /// Remove last item in the circular linked list.
        /// Time complexity - O(n) - Linear
        /// </summary>
        /// <returns></returns>
        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The linked list is empty");
                return -1;
            }

            var p = head;
            int i = 1;
            while(i < Length() - 1)
            {
                p = p.next;
                i++;
            }
            tail = p;
            tail.next = head;
            size--;

           return p.next.element;
        }

        /// <summary>
        /// Remove any fixed position in the circular linked list.
        /// Time Complewxity - o(n) - Linear
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int RemoveAnyPosition(int position)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The linked list is empty");
                return -1;
            }

            var p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            int e = p.next.element;
            p.next = p.next.next;
            size--;

            return e;
        }

        /// <summary>
        /// Traversing circular linked list.
        /// Time complexity- O(n) - Linear
        /// </summary>
        public void Display()
        {
            Node? p = head;
            int i = 0;
            while(i < Length())
            {
                Console.Write($"{p.element} ");
                p = p.next;
                i++;
            }

            Console.WriteLine();
        }
    }
}
