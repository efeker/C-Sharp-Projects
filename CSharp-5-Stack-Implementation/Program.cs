using System;

namespace Stack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Print();

            myStack.Pop();
            myStack.Print();

            myStack.Push("String");
            myStack.Print();

            var lastItem = myStack.Peek();
            Console.WriteLine(lastItem);

            myStack.Clear();
            //myStack.Print();
        }
    }
}