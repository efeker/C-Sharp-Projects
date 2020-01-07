using System;

namespace Exercises
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            //list.RemoveFirst();
            //list.RemoveLast();
            //list.ReverseList();
            //list.PrintList();
            Console.WriteLine(list.GetKthFromTheEnd(2)); 
            //Console.WriteLine(list.Size());
            //Console.WriteLine(list.IndexOf(30));
            //Console.WriteLine(list.Contains(30));

        }
    }
}
