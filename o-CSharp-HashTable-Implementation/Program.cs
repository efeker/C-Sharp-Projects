using System;

namespace Exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var table = new HashTable();
            table.Put(6, "A");
            table.Put(8, "B");
            table.Put(11, "C");
            table.Put(6, "A+");
            //table.Remove(6);
            Console.WriteLine(table.Get(6));
        }
    }
}