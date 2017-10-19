using System;
using System.Collections.Generic;
using System.Text;

namespace BSTDelete
{
    class Tree
    {
        Node root;

        public Tree()
        {
            root = null;
        }
        public Node Add(Node node, int data)
        {
            if (node == null)
            {
                return (new Node(data));
            }
            else
            {
                if (data <= node.Data)
                {
                    node.Left = Add(node.Left, data);
                }
                else
                {
                    node.Right = Add(node.Right, data);
                }
                return node;
            }
        }

        public int Minimum(Node node)
        {
            Node current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return (current.Data);
        }
        public int Maximum(Node node)
        {
            Node current = node;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return (current.Data);
        }

        public Node Delete(Node root, int data)
        {
            if (root == null) return root;
            if (data < root.Data)
            {
                root.Left = Delete(root.Left, data);
                Console.WriteLine($"{data} was deleted.");
            }
            else if (data > root.Data)
            {
                root.Right = Delete(root.Right, data);
                Console.WriteLine($"{data} was deleted.");
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                root.Data = Minimum(root.Right);
                root.Right = Delete(root.Right, root.Data);
            }
            return root;
        }
    }
}
