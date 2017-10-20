using System;

namespace SortedArrayToBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = new Tree();
            int[]arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;

            Node root = testTree.sortedArrayToBST(arr, 0, n - 1);

            Console.WriteLine("Preorder traversal of constructed binary search tree");
            testTree.preOrder(root);

            Console.Read();
        }
    }
}
