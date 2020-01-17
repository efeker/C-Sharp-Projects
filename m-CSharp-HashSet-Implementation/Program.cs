using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sets = new HashSetImplementation();
            sets.AddToSet();
            sets.SortSet();
            var con = sets.Contains(9);
            Console.WriteLine(con);
            //sets.ClearAll();
        }
    }
}