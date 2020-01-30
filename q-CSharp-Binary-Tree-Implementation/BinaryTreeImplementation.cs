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

        public int Height()
        {
            return Height(root);
        }

        private int Height(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            if (root.leftChild == null && root.rightChild == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
            }
        }

        public int Min()
        {
            return Min(root);
        }

        private int Min(Node root)
        {
            if (root.leftChild == null && root.rightChild == null)
            {
                return root.value;
            }

            var left = Min(root.leftChild);
            var right = Min(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value);
        }

        public bool AreEqual(BinaryTreeImplementation other)
        {
            return AreEqual(root, other.root);
        }

        private bool AreEqual(Node root, Node root2)
        {
            if (root == null && root2 == null)
            {
                return true;
            }

            if (root != null && root2 == null)
            {
                return false;
            }
            else if (root == null && root2 != null)
            {
                return false;
            }

            if (root != null & root2 != null)
            {
                return (root.value == root2.value)
                    && AreEqual(root.leftChild, root2.leftChild)
                    && AreEqual(root.rightChild, root2.rightChild);
            }
            else
            {
                return false;
            }
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.value < min || root.value > max)
            {
                return false;
            }

            return IsBinarySearchTree(root.leftChild, min, max: root.value - 1)
                && IsBinarySearchTree(root.rightChild, min: root.value + 1, max);
        }

        //Nodes at K Distance from the Root
        public void PrintNodesAtDistance(int distance)
        {
            PrintNodesAtDistance(root, distance);
        }

        private void PrintNodesAtDistance(Node root, int distance)
        {
            if (root == null)
            {
                return;
            }

            if (distance == 0)
            {
                Console.WriteLine(root.value);
                return;
            }

            PrintNodesAtDistance(root.leftChild, distance: distance - 1);
            PrintNodesAtDistance(root.rightChild, distance: distance - 1);
        }
    }
}