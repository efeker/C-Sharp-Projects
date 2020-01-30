using System;

namespace Exercises
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            BinaryTreeImplementation tree1 = new BinaryTreeImplementation();
            tree1.Insert(7);
            tree1.Insert(4);
            tree1.Insert(9);
            tree1.Insert(1);
            tree1.Insert(6);
            tree1.Insert(8);
            tree1.Insert(10);
            //Console.WriteLine(tree1.Find(10));
            //tree1.TraversePreOrder();
            //tree1.TraverseInOrder();
            //tree1.TraversePostOrder();
            //Console.WriteLine(tree1.Height());
            //Console.WriteLine(tree1.Min());
            //Console.WriteLine(tree1.IsBinarySearchTree()); //check if it's a binary search tree
            //tree1.PrintNodesAtDistance(2); //Nodes at K Distance from the Root

            BinaryTreeImplementation tree2 = new BinaryTreeImplementation();
            tree2.Insert(7);
            tree2.Insert(4);
            tree2.Insert(9);
            tree2.Insert(1);
            tree2.Insert(6);
            tree2.Insert(8);
            tree2.Insert(12);

            //Console.WriteLine(tree1.AreEqual(tree2)); //check if two trees are equal
        }
    }
}