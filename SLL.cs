using System;

namespace Assignment3
{
    internal class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class SLL : ILinkedListADT
    {
        private Node head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Add(object item)
        {
            AddLast(item);
        }

        public void AddLast(object item)
        {
            if (head == null)
            {
                head = new Node(item);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(item);
            }
            size++;
        }

        public void AddFirst(object item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void Replace(int index, object item)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = item;
        }

        public int Count()
        {
            return size;
        }

        public object GetValue(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1; // Item not found
        }

        public bool Contains(object item)
        {
            return IndexOf(item) != -1;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public void Remove(object item)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data.Equals(item))
            {
                head = head.Next;
                size--;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(item))
                {
                    current.Next = current.Next.Next;
                    size--;
                    return;
                }
                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }

            head = head.Next;
            size--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == null)
            {
                head = null;
                size--;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
            size--;
        }
    }
}
