using System;

namespace QueueWithTwoStacks
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var myQueue = new BuildingQueueWithTwoStacks();
            myQueue.EnQueue(1);
            myQueue.EnQueue(2);
            myQueue.EnQueue(3);

            //myQueue.PrintQueue();

            //myQueue.DeQueue();
            //myQueue.DeQueue();

            //var item = myQueue.Peek();
            //Console.WriteLine(item);

            //var lastItem = myQueue.DeQueue();
            //Console.WriteLine(lastItem);
        }
    }
}