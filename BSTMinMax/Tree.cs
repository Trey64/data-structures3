using System;
using System.Collections.Generic;
using System.Text;

namespace BSTMinMax
{
    class Tree
    {

        public Node Add(Node node, int data)
        {

            /* 1. If the tree is empty, return a new,     
             single node */
            if (node == null)
            {
                return (new Node(data));
            }
            else
            {

                /* 2. Otherwise, recur down the tree */
                if (data <= node.Data)
                {
                    node.Left = Add(node.Left, data);
                }
                else
                {
                    node.Right = Add(node.Right, data);
                }

                /* return the (unchanged) node pointer */
                return node;
            }
        }

        /* Given a non-empty binary search tree,  
         return the minimum data value found in that 
         tree. Note that the entire tree does not need 
         to be searched. */
        public int Minimum(Node node)
        {
            Node current = node;

            /* loop down to find the leftmost leaf */
            while (current.Left != null)
            {
                current = current.Left;
            }
            return (current.Data);
        }

        public int Maximum(Node node)
        {
            Node current = node;

            /* loop down to find the leftmost leaf */
            while (current.Right != null)
            {
                current = current.Right;
            }
            return (current.Data);
        }
    }
}
