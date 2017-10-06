using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breadth First Traversal \n");

            Tree testTree = new Tree(1);

            testTree.Left = new Tree(2);
            testTree.Left.Left = new Tree(4);
            testTree.Left.Right = new Tree(5);
            testTree.Right = new Tree(3);
            testTree.Right.Left = new Tree(6);
            testTree.Right.Right = new Tree(7);

            testTree.BreadthFirst();

            Console.Read();
        }
    }
}
