using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree
    {
        public Node Add(Node node, int data)
        {

            /* If the tree is empty, return a new node */
            if (node == null)
            {
                return (new Node(data));
            }
            else
            {

                /* Otherwise, recur down the tree */
                if (data <= node.Data)
                {
                    node.Left = Add(node.Left, data);
                    Console.WriteLine($"Adding node with value of {data}");
                }
                else
                {
                    node.Right = Add(node.Right, data);
                    Console.WriteLine($"Adding node with value of {data}");
                }

                /* return the (unchanged) node pointer */
                return node;
            }
        }
    }
}
