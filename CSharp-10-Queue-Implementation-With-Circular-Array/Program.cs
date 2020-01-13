namespace QueueWithCircularArray
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var myQueue = new QueueImplementation(capacity: 5);

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.DeQueue();
            myQueue.Enqueue(6);
            myQueue.DeQueue();
            myQueue.Enqueue(7);
            myQueue.DeQueue();
            myQueue.Enqueue(8);
            myQueue.Peek();
            myQueue.PrintQueue();
        }
    }
}