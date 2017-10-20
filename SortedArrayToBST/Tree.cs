using System;
using System.Collections.Generic;
using System.Text;

namespace SortedArrayToBST
{
    class Tree
    {
        /* Method that creates a Balanced Binary Search Tree from a sorted array */
        public Node sortedArrayToBST(int[]arr, int start, int end)
        {

            if (start > end)
            {
                return null;
            }

            /* Finds middle of array and makes it root */
            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);

            /* Recursively find middle of left half and make it left child */
            node.Left = sortedArrayToBST(arr, start, mid - 1);

            /* Recursively find middle of right half and make it right child */
            node.Right = sortedArrayToBST(arr, mid + 1, end);

            return node;
        }

        /* Method to print preorder traversal of BST */
        public void preOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine($"{node.Data}" + "");

            preOrder(node.Left);
            preOrder(node.Right);
        }

    }
}
