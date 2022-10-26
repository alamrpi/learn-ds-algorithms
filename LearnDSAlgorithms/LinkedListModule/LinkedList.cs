﻿namespace LearnDSAlgorithms.LinkedListModule
{
    public class LinkedList
    {
        private Node? head;
        private Node? tail;
        private int size;

        //Constructor
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length() => size;

        public bool IsEmpty() => size == 0;

        public void AddLast(int e)
        {
            Node newest = new(e, null);
            if (IsEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
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
            Node newest = new Node(e, null);
            Node p = head;
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
            Node p = head;
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
            Node p = head;
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

    }
}