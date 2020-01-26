using System;

namespace Exercises
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            BinaryTreeImplementation three = new BinaryTreeImplementation();
            three.Insert(7);
            three.Insert(4);
            three.Insert(9);
            three.Insert(1);
            three.Insert(6);
            three.Insert(8);
            three.Insert(10);
            //var b = three.Find(10);
            //Console.WriteLine(b);
            //three.TraversePreOrder();
            //three.TraverseInOrder();
            //three.TraversePostOrder();
        }
    }
}