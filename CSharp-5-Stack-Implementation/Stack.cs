using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new Exception("You cannot add null object to the stack");
            }
            else
            {
                _list.Add(obj);
            }
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new Exception("There are no elements in the stack");
            }
            else
            {
                var lastItem = _list.Count - 1;

                var toReturn = _list[lastItem];

                _list.RemoveAt(lastItem);

                return (toReturn);
            }
        }

        public void Print()
        {
            if (!_list.Any())
            {
                throw new Exception("Stack is already empty");
            }
            else
            {
                foreach (object nums in _list)
                {
                    Console.WriteLine(nums);
                }
            }
            NewLine();
        }

        public object Peek()
        {
            if (!_list.Any())
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                var lastObject = _list.Last();

                Console.WriteLine(lastObject);
            }
            return 0;
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}