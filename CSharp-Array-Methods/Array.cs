using System;
using System.Linq;

namespace ArrayExercises
{
    partial class Program
    {
        public class ArrayFunctions
        {
            private int[] myArray;
            private int count;

            public ArrayFunctions(int length)
            {
                myArray = new int[length];
            }

            public void Insert(int item)
            {
                if (myArray.Length == count)
                {
                    int[] newItems = new int[count * 2];
                    for (int i = 0; i < count; i++)
                    {
                        newItems[i] = myArray[i];
                    }
                    myArray = newItems;
                }
                myArray[count++] = item;
            }

            public int FindMax()
            {
                var max = myArray[0];
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > max)
                    {
                        max = myArray[i];
                    }
                }
                return max;
            }

            public void FindIntersect()
            {
                int[] dummyArray = new int[] { 30, 40 };

                var intersect = myArray.Intersect(dummyArray);

                foreach (int numbers in intersect)
                {
                    Console.WriteLine(numbers);
                }
            }

            public void ReverseArray()
            {
                int[] temproraryArray = myArray;

                Array.Reverse(temproraryArray);

                foreach (int numbers in myArray)
                {
                    Console.WriteLine(numbers);
                }
            }

            public void InsertAt(int index, int value)
            {
                for (int i = myArray.Length - 1; i > index; i--)
                {
                    myArray[i] = myArray[i - 1];
                }

                myArray[index] = value;

                foreach (int nums in myArray)
                {
                    Console.WriteLine(nums);
                }
            }

            public void RemoveAt(int index)
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                for (int i = 0; i < count; i++)
                {
                    myArray[i] = myArray[i + 1];
                }
                count--;
            }

            public int IndexOf(int item)
            {
                for (int i = 0; i < count; i++)
                {
                    if (myArray[i] == item)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public void Print()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
    }
}
