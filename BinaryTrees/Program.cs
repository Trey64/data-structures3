using System;

namespace BinaryTrees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo, check out my tree \n");

            Tree treeTest = new Tree();

            treeTest.CreateTree("Root");
            treeTest.PrintTree();

            Console.Read();
        }
    }
}
