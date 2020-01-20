using System;

namespace PriorityQueueImplementation
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var myQueue = new PriorityQueue(capacity: 5);
            myQueue.Add(5);
            myQueue.Add(3);
            myQueue.Add(1);
            myQueue.Add(6);
            myQueue.Add(4);
            myQueue.PrintQueue();

            while (!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Remove());
            }
        }
    }
}