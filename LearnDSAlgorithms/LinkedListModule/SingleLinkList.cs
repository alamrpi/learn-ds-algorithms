namespace LearnDSAlgorithms.LinkedListModule
{
    public class SingleLinkList : LinkedList<SingleNode>
    {
        public void AddLast(int e)
        {
            SingleNode newest = new(e, null);
            if (IsEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            SingleNode newest = new SingleNode(e, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }
        public void AddAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            var newest = new SingleNode(e, null);
            var p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i++;
            }
            newest.next = p.next;
            p.next = newest;
            size++;
        }

        public int? RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size--;
                if (IsEmpty())
                    tail = null;
                return e;
            }
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            var p = head;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i++;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size--;
            return e;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
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

        public int Search(int key)
        {
            var p = head;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;

                index++;
            }
            return -1;
        }

        public void Insertsorted(int e)
        {
            var newest = new SingleNode(e, null);
            if (IsEmpty())
                head = newest;
            else
            {
                var p = head;
                var q = head;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size++;
        }
    }
}
