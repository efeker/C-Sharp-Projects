namespace QueueWithCircularArray
{
    public class QueueImplementation
    {
        private int[] nums;
        private int front = -1;
        private int rear = -1;

        public QueueImplementation(int capacity)
        {
            nums = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if ((rear + 1) % nums.Length == front)
            {
                return;
            }
            else if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % nums.Length;
            }
            nums[rear] = item;
        }

        public void DeQueue()
        {
            if (IsEmpty())
            {
                return;
            }
            else if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % nums.Length;
            }
        }

        public bool IsEmpty()
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Peek()
        {
            System.Console.WriteLine("Front of the Queue is --> " + nums[front] + "\n");
        }

        public void PrintQueue()
        {
            foreach (int queue in nums)
            {
                System.Console.WriteLine(queue);
            }
        }
    }
}