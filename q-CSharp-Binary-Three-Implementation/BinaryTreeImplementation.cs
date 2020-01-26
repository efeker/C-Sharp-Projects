using System;

namespace Exercises
{
    public class BinaryTreeImplementation
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            public string toString()
            {
                return "Node=" + value;
            }
        }

        private Node root;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find(int value)
        {
            var current = root;
            while (current != null)
            {
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node root)
        {
            //Root, Left, Right
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node root)
        {
            //Left, Root, Right
            if (root == null)
            {
                return;
            }

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node root)
        {
            //Left, Right, Root
            if (root == null)
            {
                return;
            }

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }
    }
}