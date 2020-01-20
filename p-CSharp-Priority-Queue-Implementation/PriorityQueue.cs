using System;

namespace PriorityQueueImplementation
{
    public class PriorityQueue
    {
        private int[] items;
        private int count;

        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Add(int item)
        {
            if (count == items.Length)
            {
                throw new Exception("Queue is full");
            }
            //shifting items
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                {
                    items[i + 1] = items[i];
                }
                else
                {
                    break;
                }
            }
            items[i + 1] = item;
            count++;
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty!");
            }
            return items[--count];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void PrintQueue()
        {
            foreach (int nums in items)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();
        }
    }
}