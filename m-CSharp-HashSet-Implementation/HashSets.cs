using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class HashSetImplementation
    {
        private HashSet<int> set = new HashSet<int>();

        private int[] numbers = { 8, 9, 8, 7, 10, 1, 3, 5, 2 };
        private int[] temp;

        public void AddToSet()
        {
            foreach (int nums in numbers)
            {
                set.Add(nums);
            }
        }

        public void SortSet()
        {
            temp = set.ToArray();

            Array.Sort(temp);

            set.Clear();

            set.UnionWith(temp);

            foreach (int num in set)
            {
                Console.WriteLine(num);
            }
        }

        public bool Contains(int item)
        {
            if (numbers.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearAll()
        {
            Array.Clear(numbers, 0, numbers.Length);

            Console.WriteLine("Array values cleared!");
        }
    }
}