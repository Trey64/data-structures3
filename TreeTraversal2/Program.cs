using System;

namespace TreeTraversal2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PostOrder Traversal \n");

            Tree testTree = new Tree(1);

            testTree.Left = new Tree(2);
            testTree.Left.Left = new Tree(3);
            testTree.Left.Right = new Tree(4);
            testTree.Right = new Tree(5);
            testTree.Right.Left = new Tree(6);
            testTree.Right.Right = new Tree(7);

            testTree.PostOrder();

            Console.WriteLine("");
            Console.WriteLine("InOrder Traversal \n");

            testTree.InOrder();

            Console.Read();
        }
    }
}
