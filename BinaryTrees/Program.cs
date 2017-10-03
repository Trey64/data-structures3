using System;

namespace BinaryTrees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo, check out my tree");
            Console.WriteLine("");

            Tree treeTest = new Tree();

            treeTest.CreateTree("Root");
            treeTest.PrintTree();

            Console.Read();
        }
    }
}
