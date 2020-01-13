using System;

namespace Exercises
{
    public class LinkedList
    {
        public class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public void AddLast(int item)
        {
            var node = new Node(item);

            if(isEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;

        }

        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;

            while(current != null)
            {
                if (current.value == item)
                {
                    return index;
                }
                else
                {
                    current = current.next;
                }
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if (isEmpty())
            {
                throw new Exception("List is empty!");
            }

            if(first == last)
            {
                first = last = null;
                return;
            }
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            size--;
        }

        public void RemoveLast()
        {
          if (isEmpty())
            {
                throw new Exception("List is empty!");
            }

            if (first == last)
            {
                first = last = null;
                return;
            }
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }
            size--;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                else
                {
                    current = current.next;
                }
            }
            return null;
        }

        public int Size()
        {
            return size;
        }

        public void ReverseList() 
        {
            Node current = first;
            Node prev = null;
            Node next;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            first = prev;
        }

        public int GetKthFromTheEnd(int k)
        {
            var a = first;
            var b = first;
            for (int i=0; i < k-1; i++)
            {
                b = b.next;
                if (b == null)
                {
                    throw new Exception("Given number is greater than size of the linked list");
                }
            }
            while (b != last)
            {
                a = a.next;
                b = b.next;
            }
            return a.value;
        }

        public void PrintList()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine(current.value + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        private bool isEmpty()
        {
            return first == null;
        }
    }
}
