using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public class Tree
    {
        public Leaf Root;

        public void CreateTree(string data)
        {
            Root = new Leaf(data);
            Root.Left = new Leaf("One");
            Root.Right = new Leaf(" Two");
            Root.Left.Left = new Leaf("Three");
            Root.Left.Right = new Leaf(" Four");
            Root.Right.Left = new Leaf(" Five");
            Root.Right.Right = new Leaf(" Six");
        }

        public void PrintTree()
        {
            Console.WriteLine(Root.Data);
            Console.WriteLine(Root.Left.Data + Root.Right.Data);
            Console.WriteLine(Root.Left.Left.Data + Root.Left.Right.Data + Root.Right.Left.Data + Root.Right.Right.Data);
        }
    }
}
