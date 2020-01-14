using System;
using System.Collections.Generic;

namespace QueueWithTwoStacks
{
    public class BuildingQueueWithTwoStacks
    {
        private readonly Stack<int> stack1 = new Stack<int>();
        private readonly Stack<int> stack2 = new Stack<int>();

        public void EnQueue(int item)
        {
            stack1.Push(item);
        }

        public int DeQueue()
        {
            IsEmpty();

            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }

        public void PrintQueue()
        {
            IsEmpty();

            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }

            foreach (int nums in stack2)
            {
                Console.WriteLine(nums);
            }
        }

        public int Peek()
        {
            IsEmpty();

            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Peek();
        }

        public void IsEmpty()
        {
            if ((stack2.Count == 0) && (stack1.Count == 0))
            {
                throw new Exception("Stack is empty");
            }
        }
    }
}