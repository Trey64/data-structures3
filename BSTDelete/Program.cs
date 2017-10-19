using System;

namespace BSTDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = new Tree();
            Node root = null;
            root = testTree.Add(root, 4);
            testTree.Add(root, 2);
            testTree.Add(root, 1);
            testTree.Add(root, 3);
            testTree.Add(root, 6);
            testTree.Add(root, 5);

            Console.WriteLine("The minimum value of my tree is " + testTree.Minimum(root));
            Console.WriteLine("The maximum value of my tree is " + testTree.Maximum(root));

            testTree.Delete(root, 2);

            Console.Read();
        }
    }
}
